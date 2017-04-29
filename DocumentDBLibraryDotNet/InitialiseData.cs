using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ObligationDueDates.ObjectsDotNet;

namespace DocumentDBLibraryDotNet
{
    public class InitialiseData
    {
        public List<Obligation> Load()
        {
            List<Obligation> obligations = new List<Obligation>();

            List<string> processes = new List<string>() { "Tax" };
            Jurisdiction jurisdiction = new Jurisdiction { Country = "United States", State = "Ohio", City = "Hubbard" };

            Obligation obligation = new Obligation();
            obligation.Id = "us_oh_hubbard_bt_file_q100_est_tax_pmt_02_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "OH Hubbard Q1100, Est Tax PMT 02";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "us_oh_hubbard_bt_file_q100_est_tax_pmt_02_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United States", State = "Ohio", City = "Hubbard" };
            obligation = new Obligation();
            obligation.Id = "us_oh_hubbard_bt_file_q100_est_tax_pmt_02_2016";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "OH Hubbard Q1100, Est Tax PMT 02";
            obligation.Processes = processes;
            obligation.Year = 2016;
            obligation.PriorId = "us_oh_hubbard_bt_file_q100_est_tax_pmt_02_2015";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_file_ct600_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "CT600 Filing";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "uk_ct_file_ct600_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_pay1_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "Payment 1";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "uk_ct_pay1_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_pay2_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "Payment 2";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "uk_ct_pay2_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_pay3_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "Payment 3";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "uk_ct_pay3_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_pay4_2015";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "Payment 4";
            obligation.Processes = processes;
            obligation.Year = 2015;
            obligation.PriorId = "uk_ct_pay4_2014";
            obligations.Add(obligation);

            jurisdiction = new Jurisdiction { Country = "United Kingdom" };
            obligation = new Obligation();
            obligation.Id = "uk_ct_file_ct600_2016";
            obligation.Jursidiction = jurisdiction;
            obligation.Name = "CT600 Filing";
            obligation.Processes = processes;
            obligation.Year = 2016;
            obligation.PriorId = "uk_ct_file_ct600_2015";
            obligations.Add(obligation);



            return obligations;

        }
    }
}
