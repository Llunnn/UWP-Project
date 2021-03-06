﻿#pragma checksum "G:\作业\现操\期中\project\UWP-Project\ShowMeMyMoney\Account.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF1BF28CF6DE1362CDC7BE424C4F5790"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShowMeMyMoney
{
    partial class Account : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Data_CollectionViewSource_Source(global::Windows.UI.Xaml.Data.CollectionViewSource obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class Account_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAccount_Bindings
        {
            private global::ShowMeMyMoney.Account dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Data.CollectionViewSource obj2;
            private global::Windows.UI.Xaml.Data.CollectionViewSource obj3;

            public Account_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Data.CollectionViewSource)target;
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Data.CollectionViewSource)target;
                        break;
                    default:
                        break;
                }
            }

            // IAccount_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Account_obj1_Bindings

            public void SetDataRoot(global::ShowMeMyMoney.Account newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ShowMeMyMoney.Account obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CategoryViewModel(obj.CategoryViewModel, phase);
                    }
                }
            }
            private void Update_CategoryViewModel(global::ShowMeMyMoney.ViewModel.categoryViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_CategoryViewModel_AllExpenseCatagoryItems(obj.AllExpenseCatagoryItems, phase);
                        this.Update_CategoryViewModel_AllIncomeCatagoryItems(obj.AllIncomeCatagoryItems, phase);
                    }
                }
            }
            private void Update_CategoryViewModel_AllExpenseCatagoryItems(global::System.Collections.ObjectModel.ObservableCollection<global::ShowMeMyMoney.Model.categoryItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Data_CollectionViewSource_Source(this.obj2, obj, null);
                }
            }
            private void Update_CategoryViewModel_AllIncomeCatagoryItems(global::System.Collections.ObjectModel.ObservableCollection<global::ShowMeMyMoney.Model.categoryItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Data_CollectionViewSource_Source(this.obj3, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.ExpenseCGList = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 3:
                {
                    this.IncomeCGList = (global::Windows.UI.Xaml.Data.CollectionViewSource)(target);
                }
                break;
            case 4:
                {
                    this.ExpenseCategory = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 5:
                {
                    this.IncomeCategory = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 6:
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.Date = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 8:
                {
                    this.createButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 56 "..\..\..\Account.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.createButton).Click += this.createButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.canclButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 58 "..\..\..\Account.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.canclButton).Click += this.canclButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.Amount = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.PocketMoney = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 12:
                {
                    this.expense = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 33 "..\..\..\Account.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.expense).Checked += this.out_Checked;
                    #line default
                }
                break;
            case 13:
                {
                    this.income = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 34 "..\..\..\Account.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.income).Checked += this.income_Checked;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Account_obj1_Bindings bindings = new Account_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

