using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Inventory.DataModels;
using Inventory.DataModels.StockTake;

namespace Inventory.Forms.StockTake
{
    public partial class PeriodClosing : DevExpress.XtraEditors.XtraForm
    {
        public PeriodClosing()
        {
            InitializeComponent();
        }

        //Stock Transfer Model
        private PeriodClosingModel model = new PeriodClosingModel();

        /// <summary>
        /// Get/set data model StockTransfer 
        /// </summary>
        public PeriodClosingModel DataModel
        {
            get { return model; }
            set { model = value; }
        }

        private void btnClosePeriod_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            ReadToDataModel();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void BindData(PeriodClosingModel objModel)
        {
            //In case of adding new packing list, initialize the grid with nodata
            if (objModel == null)
            {
                model = new PeriodClosingModel();
            }
            else
            {
                model = objModel;
            }
            
            cboType.Properties.Items.Clear();
            DataTable dtTypes = Mediator.GetInstance().GetAllPeriodType();
            dtTypes.DefaultView.Sort = "Name";
            foreach (DataRow row in dtTypes.Rows)
            {
                cboType.Properties.Items.Add(new TabItem(row["ID"].ToString(), row["Name"].ToString()));
            }

            foreach (TabItem tab in cboType.Properties.Items)
            {
                if (Constants.PeriodClosing.MonthlyType == tab.ItemName)
                {
                    cboType.SelectedIndex = cboType.Properties.Items.IndexOf(tab);
                }
            }

            // not contains Monthly type, set the default to the first type
            if (cboType.Properties.Items.Count > 0 && cboType.SelectedIndex == -1)
            {
                cboType.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Implement ReadToDataModel
        /// </summary>
        protected void ReadToDataModel()
        {
            model.Type = ((TabItem)cboType.SelectedItem).ItemID;
            model.TypeName = ((TabItem)cboType.SelectedItem).ItemName;
            model.StartDate = this.GetStartDate();
            model.EndDate = Utils.DateUtils.GetPeriodEndDate(model.StartDate, cboType.Text);

            //model.Status = false;
            model.State = chkViewState.Checked;
            model.Description = txtDescription.Text;
        }

        public bool ValidateData()
        {
            Validator objValidator = new Validator();
            
            if (!objValidator.IsNonEmpty("Period Type", cboType.Text))
            {
                cboType.Focus();
                return false;
            }

            return true;
        }

        private void PeriodClosing_Load(object sender, EventArgs e)
        {
            int intCurrentYear = DateTime.Now.Year;
            for (int i = intCurrentYear - 5; i < intCurrentYear + 5; i++)
            {
                cboStartYear.Properties.Items.Add(i);
                cboEndYear.Properties.Items.Add(i);
            }

            cboEndYear.Properties.Items.Add(intCurrentYear + 5);

            cboStartYear.Text = intCurrentYear.ToString();
            cboEndYear.Text = intCurrentYear.ToString();
            this.InputChangedEvent(sender, e);
        }

        void InputChangedEvent(object sender, EventArgs e)
        {
            cboStartMonth.Properties.Items.Clear();
            cboStartDay.Properties.Items.Clear();

            if (Constants.PeriodClosing.AnnuallyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = false;
                cboStartDay.Enabled = false;
            }
            else if (Constants.PeriodClosing.SemiAnnuallyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = true;
                cboStartMonth.Properties.Items.Add("1");
                cboStartMonth.Properties.Items.Add("6");
                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || cboStartMonth.Text == "")
                {
                    cboStartMonth.Text = "1";
                }

                cboStartDay.Enabled = false;
            }
            else if (Constants.PeriodClosing.QuarterlyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = true;
                cboStartMonth.Properties.Items.Add("1");
                cboStartMonth.Properties.Items.Add("4");
                cboStartMonth.Properties.Items.Add("7");
                cboStartMonth.Properties.Items.Add("10");
                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || cboStartMonth.Text == "")
                {
                    cboStartMonth.Text = "1";
                }

                cboStartDay.Enabled = false;
            }
            else if (Constants.PeriodClosing.MonthlyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = true;
                for (int i = 1; i <= 12; i++)
                {
                    cboStartMonth.Properties.Items.Add(i.ToString());
                }

                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || cboStartMonth.Text == "")
                {
                    cboStartMonth.Text = "1";
                }

                cboStartDay.Enabled = false;
            }
            else if (Constants.PeriodClosing.WeeklyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = true;
                for (int i = 1; i <= 12; i++)
                {
                    cboStartMonth.Properties.Items.Add(i.ToString());
                }

                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || cboStartMonth.Text == "")
                {
                    cboStartMonth.Text = "1";
                }

                cboStartDay.Enabled = true;
                int intFistWeekDay = 0; // the first day of the first week in the month
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(cboStartYear.Text), Convert.ToInt32(cboStartMonth.Text)); i++)
                {
                    DateTime dtm = new DateTime(Convert.ToInt32(cboStartYear.Text), Convert.ToInt32(cboStartMonth.Text), i);
                    if (dtm.DayOfWeek == DayOfWeek.Monday)
                    {
                        cboStartDay.Properties.Items.Add(i.ToString());
                        if (intFistWeekDay == 0)
                        {
                            intFistWeekDay = i;
                        }
                    }
                }

                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || sender.Equals(cboStartMonth) || cboStartMonth.Text == "")
                {
                    cboStartDay.Text = intFistWeekDay.ToString();
                }
            }
            else if (Constants.PeriodClosing.DailyType.Equals(cboType.Text, StringComparison.CurrentCultureIgnoreCase))
            {
                cboStartMonth.Enabled = true;
                for (int i = 1; i <= 12; i++)
                {
                    cboStartMonth.Properties.Items.Add(i.ToString());
                }

                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || cboStartMonth.Text == "")
                {
                    cboStartMonth.Text = "1";
                }

                cboStartDay.Enabled = true;
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt32(cboStartYear.Text), Convert.ToInt32(cboStartMonth.Text)); i++)
                {
                    cboStartDay.Properties.Items.Add(i.ToString());
                }

                if (sender.Equals(cboType) || sender.Equals(cboStartYear) || sender.Equals(cboStartMonth) || cboStartMonth.Text == "")
                {
                    cboStartDay.Text = "1";
                }
            }

            
            // set default month and day for start date if it is not enable
            if (!cboStartMonth.Enabled)
            {
                cboStartMonth.Text = "1";
            }
            if (!cboStartDay.Enabled)
            {
                cboStartDay.Text = "1";
            }

            // get end date by period type and start date
            DateTime dtmStartDate = this.GetStartDate();
            if (dtmStartDate == DateTime.MinValue)
            {
                cboEndYear.Text = "";
                cboEndMonth.Text = "";
                cboEndDay.Text = "";
            }
            else
            {
                DateTime dtmEndDate = Utils.DateUtils.GetPeriodEndDate(dtmStartDate, cboType.Text);

                cboEndYear.Text = dtmEndDate.Year.ToString();
                cboEndMonth.Text = dtmEndDate.Month.ToString();
                cboEndDay.Text = dtmEndDate.Day.ToString();
            }
        }

        private DateTime GetStartDate()
        {
            if (cboStartYear.Text == "" || cboStartMonth.Text == "" || cboStartDay.Text == "")
            {
                return DateTime.MinValue;
            }

            DateTime dtmStart = new DateTime(Convert.ToInt32(cboStartYear.Text), Convert.ToInt32(cboStartMonth.Text), Convert.ToInt32(cboStartDay.Text));
            return dtmStart;
        }
    }
}