using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using test1.DataBase;
using test1.DataBase.Models;

namespace test1
{
    public partial class Form1 : Form
    {
        private readonly EmployeeRepository _repo;

        public Form1()
        {
            InitializeComponent();
            _repo = new EmployeeRepository(new AppDbContext());
            LoadFilters();
            SetupSortControls();
            SetupGrid();
            ApplyFilters();
            btnApply.Click += (_, __) => ApplyFilters();
            btnShowStats.Click += (_, __) => ShowStatisticsOxy();
        }

        private void LoadFilters()
        {
            var statuses = _repo.GetStatuses();
            statuses.Insert(0, new Status { Id = 0, Name = "Все" });
            cbStatus.DataSource = statuses;
            cbStatus.DisplayMember = "Name";
            cbStatus.ValueMember = "Id";

            var deps = _repo.GetDeps();
            deps.Insert(0, new Dep { Id = 0, Name = "Все" });
            cbDep.DataSource = deps;
            cbDep.DisplayMember = "Name";
            cbDep.ValueMember = "Id";

            var posts = _repo.GetPosts();
            posts.Insert(0, new Post { Id = 0, Name = "Все" });
            cbPost.DataSource = posts;
            cbPost.DisplayMember = "Name";
            cbPost.ValueMember = "Id";

            cbStatStatus.DataSource = _repo.GetStatuses();
            cbStatStatus.DisplayMember = "Name";
            cbStatStatus.ValueMember = "Id";
        }

        private void SetupSortControls()
        {
            cbSort.DataSource = new[]
            {
                new SortOption(null, ""),
                new SortOption("LastName", "ФИО"),
                new SortOption("StatusName", "Статус"),
                new SortOption("DepName", "Отдел"),
                new SortOption("PostName", "Должность"),
                new SortOption("DateEmploy", "Дата приёма"),
                new SortOption("DateUneploy", "Дата увольнения")
            };
            cbSort.DisplayMember = "Text";
            cbSort.ValueMember = "Value";

            cbSortDirection.DataSource = new[]
            {
                new SortOption(null, ""),
                new SortOption("ASC", "По возрастанию"),
                new SortOption("DESC", "По убыванию")
            };
            cbSortDirection.DisplayMember = "Text";
            cbSortDirection.ValueMember = "Value";
        }

        private void SetupGrid()
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.Columns.Clear();
            AddCol("FullName", "ФИО", 200);
            AddCol("StatusName", "Статус", 120);
            AddCol("DepName", "Отдел", 150);
            AddCol("PostName", "Должность", 150);
            AddCol("DateEmploy", "Дата приёма", 120, "dd.MM.yyyy");
            AddCol("DateUneploy", "Дата увольнения", 120, "dd.MM.yyyy");
        }

        private void AddCol(string prop, string header, int width, string format = null)
        {
            var col = new DataGridViewTextBoxColumn
            {
                DataPropertyName = prop,
                HeaderText = header,
                Width = width
            };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvEmployees.Columns.Add(col);
        }

        private void ApplyFilters()
        {
            int? s = (int)cbStatus.SelectedValue > 0 ? (int?)cbStatus.SelectedValue : null;
            int? d = (int)cbDep.SelectedValue > 0 ? (int?)cbDep.SelectedValue : null;
            int? p = (int)cbPost.SelectedValue > 0 ? (int?)cbPost.SelectedValue : null;
            string ln = string.IsNullOrWhiteSpace(tbLastName.Text) ? null : tbLastName.Text.Trim();
            string sc = cbSort.SelectedValue as string;
            string sd = cbSortDirection.SelectedValue as string;
            if (string.IsNullOrEmpty(sc) || string.IsNullOrEmpty(sd)) sc = sd = null;

            dgvEmployees.DataSource = _repo.GetEmployees(s, d, p, ln, sc, sd);

            foreach (DataGridViewRow row in dgvEmployees.Rows)
            {
                if (row.DataBoundItem is EmployeeDto e && e.DateUneploy.HasValue)
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void ShowStatisticsOxy()
        {
            if (cbStatStatus.SelectedValue == null) return;
            int id = (int)cbStatStatus.SelectedValue;
            DateTime from = dtpStart.Value.Date;
            DateTime to = dtpEnd.Value.Date;
            bool employed = rbEmployed.Checked;
            if (from > to)
            {
                MessageBox.Show("Дата начала позже даты конца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stats = _repo.GetStats(id, from, to, employed);
            var model = new PlotModel
            {
                Title = $"Статистика {(employed ? "принятых" : "уволенных")} ({cbStatStatus.Text})"
            };
            model.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "MM.dd",
                Angle = -45,
                IntervalType = DateTimeIntervalType.Days,
                IntervalLength = 80,
                IsZoomEnabled = false,
                IsPanEnabled = false
            });
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                MinimumPadding = 0,
                AbsoluteMinimum = 0
            });

            var line = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                StrokeThickness = 2,
                Color = OxyColors.SteelBlue
            };
            foreach (var r in stats)
                line.Points.Add(DateTimeAxis.CreateDataPoint(r.Date, r.Count));
            model.Series.Add(line);
            plotViewStats.Model = model;
        }
    }

    public class SortOption
    {
        public string Value { get; }
        public string Text { get; }
        public SortOption(string value, string text) { Value = value; Text = text; }
    }
}
