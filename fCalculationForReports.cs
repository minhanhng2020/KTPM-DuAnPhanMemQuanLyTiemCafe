using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuAnPhanMemQuanLyTiemCafe
{
    public class fCalculationForReports
    {
        private double income;
        private double cost;
        private double revenue;

        public fCalculationForReports(double income, double cost, double revenue)
        {
            this.income = income;
            this.cost = cost;
            this.revenue = revenue;
        }

        public double Execute(string Operator)
        {
            double rlt = 0;
            switch (Operator)
            {
                case "Doanh Thu":
                    rlt = this.revenue + this.cost;
                    break;
                case "Chi Phí":
                    rlt = this.income - this.revenue;
                    break;
                case "Lợi Nhuận":
                    rlt = this.income - this.cost;
                    break;
            }

            return rlt;
        }
    }
}
