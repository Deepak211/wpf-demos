#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel;

namespace StackingLine100Chart
{
    public class StackingLineChartViewModel
    {
        public StackingLineChartViewModel()
        {

            this.MonthlyExpense = new ObservableCollection<Expense>();

            MonthlyExpense.Add(new Expense() { Name = "Food", Father = 55, Mother = 40, Son = 45, Daughter = 48 });
            MonthlyExpense.Add(new Expense() { Name = "Transport", Father = 33, Mother = 45, Son = 54, Daughter = 28 });
            MonthlyExpense.Add(new Expense() { Name = "Medical", Father = 43, Mother = 23, Son = 20, Daughter = 34 });
            MonthlyExpense.Add(new Expense() { Name = "Clothes", Father = 32, Mother = 54, Son = 23, Daughter = 84 });
            MonthlyExpense.Add(new Expense() { Name = "Books", Father = 56, Mother = 18, Son = 43, Daughter = 55 });
            MonthlyExpense.Add(new Expense() { Name = "Others", Father = 23, Mother = 54, Son = 33, Daughter = 56 });
        }

        public ObservableCollection<Expense> MonthlyExpense
        {
            get;
            set;
        }
    }
}
