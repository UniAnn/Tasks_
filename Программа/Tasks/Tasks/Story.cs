using System;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Story : Form
    {
        Period selectedPeriod;

        public Story()
        {
            InitializeComponent();
            CurrentFinance();
            selectedPeriod = Period.day;
            InitializePeriods();
        }
        void InitializePeriods()
        {
            
        }
        double GetPeriodFinance(DateTime dateFinish)
        {
            return 0;
        }
        void CurrentFinance()
        {

        }
        enum Period
        {
            day,
            week,
            month,
            year
        }
        void LoadNext(DateTime dateFinish)
        {

        }
        void LoadPrevious(DateTime dateStart)
        {

        }
        DateTime GetPeriodStart(DateTime dateFinish)
        {
            return DateTime.Now;
        }
    }
}
