﻿using System.Collections.Generic;

namespace ECommerceWebsite.Models.Admin
{
    public class AdminHomeViewModel : AdminBaseViewModel
    {
        public List<ProductStockViewModel> LowStockProducts { get; set; }
        public List<NewUserViewModel> NewUsers { get; set; }
        public List<LatestTransactionsViewModel> LatestTransactions { get; set; }
        public List<FinancialInformationViewModel> FinancialInformation { get; set; }

        public AdminHomeViewModel()
        {
            LowStockProducts = new List<ProductStockViewModel>();
            NewUsers = new List<NewUserViewModel>();
            LatestTransactions = new List<LatestTransactionsViewModel>();
            FinancialInformation = new List<FinancialInformationViewModel>();
        }
    }
}