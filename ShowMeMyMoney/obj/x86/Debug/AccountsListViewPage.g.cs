﻿#pragma checksum "G:\作业\现操\期中\project\UWP-Project\ShowMeMyMoney\AccountsListViewPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8236351EDFD1205818F092DD74936B80"
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
    partial class AccountsListViewPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class AccountsListViewPage_obj28_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAccountsListViewPage_Bindings
        {
            private global::ShowMeMyMoney.Model.categoryItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj28;
            private global::Windows.UI.Xaml.Controls.TextBlock obj29;

            public AccountsListViewPage_obj28_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 28:
                        this.obj28 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Border)target);
                        break;
                    case 29:
                        this.obj29 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ShowMeMyMoney.Model.categoryItem data = args.NewValue as global::ShowMeMyMoney.Model.categoryItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ShowMeMyMoney.Model.categoryItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::ShowMeMyMoney.Model.categoryItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Border)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ShowMeMyMoney.Model.categoryItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IAccountsListViewPage_Bindings

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

            // AccountsListViewPage_obj28_Bindings

            public void SetDataRoot(global::ShowMeMyMoney.Model.categoryItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ShowMeMyMoney.Model.categoryItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_color(obj.color, phase);
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_color(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj28.Target as global::Windows.UI.Xaml.Controls.Border, (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), obj), null);
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj29, obj, null);
                }
            }
        }

        private class AccountsListViewPage_obj30_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAccountsListViewPage_Bindings
        {
            private global::ShowMeMyMoney.Model.categoryItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj30;
            private global::Windows.UI.Xaml.Controls.TextBlock obj31;

            public AccountsListViewPage_obj30_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 30:
                        this.obj30 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Border)target);
                        break;
                    case 31:
                        this.obj31 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ShowMeMyMoney.Model.categoryItem data = args.NewValue as global::ShowMeMyMoney.Model.categoryItem;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ShowMeMyMoney.Model.categoryItem was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::ShowMeMyMoney.Model.categoryItem);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Border)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ShowMeMyMoney.Model.categoryItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IAccountsListViewPage_Bindings

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

            // AccountsListViewPage_obj30_Bindings

            public void SetDataRoot(global::ShowMeMyMoney.Model.categoryItem newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ShowMeMyMoney.Model.categoryItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_color(obj.color, phase);
                        this.Update_name(obj.name, phase);
                    }
                }
            }
            private void Update_color(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj30.Target as global::Windows.UI.Xaml.Controls.Border, (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), obj), null);
                }
            }
            private void Update_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj31, obj, null);
                }
            }
        }

        private class AccountsListViewPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAccountsListViewPage_Bindings
        {
            private global::ShowMeMyMoney.AccountsListViewPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj25;
            private global::Windows.UI.Xaml.Controls.ListView obj26;
            private global::Windows.UI.Xaml.Controls.ListView obj27;

            public AccountsListViewPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 25:
                        this.obj25 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 26:
                        this.obj26 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 27:
                        this.obj27 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IAccountsListViewPage_Bindings

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

            // AccountsListViewPage_obj1_Bindings

            public void SetDataRoot(global::ShowMeMyMoney.AccountsListViewPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ShowMeMyMoney.AccountsListViewPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                        this.Update_categoryViewModel(obj.categoryViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::ShowMeMyMoney.ViewModel.ViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DisplayItems(obj.DisplayItems, phase);
                    }
                }
            }
            private void Update_ViewModel_DisplayItems(global::System.Collections.ObjectModel.ObservableCollection<global::ShowMeMyMoney.Model.accountItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj25, obj, null);
                }
            }
            private void Update_categoryViewModel(global::ShowMeMyMoney.ViewModel.categoryViewModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_categoryViewModel_AllExpenseCatagoryItems(obj.AllExpenseCatagoryItems, phase);
                        this.Update_categoryViewModel_AllIncomeCatagoryItems(obj.AllIncomeCatagoryItems, phase);
                    }
                }
            }
            private void Update_categoryViewModel_AllExpenseCatagoryItems(global::System.Collections.ObjectModel.ObservableCollection<global::ShowMeMyMoney.Model.categoryItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj26, obj, null);
                }
            }
            private void Update_categoryViewModel_AllIncomeCatagoryItems(global::System.Collections.ObjectModel.ObservableCollection<global::ShowMeMyMoney.Model.categoryItem> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj27, obj, null);
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
                    this.myTitle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 3:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.VisualStateMin0 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.VisualStateMin900 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.main = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 7:
                {
                    this.details = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.category = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.amount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.inOrOut = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.isPocketMoney = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.date = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element14 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 216 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element14).Click += this.edit_click;
                    #line default
                }
                break;
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element15 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 217 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element15).Click += this.delete_click;
                    #line default
                }
                break;
            case 16:
                {
                    this.details_bottom = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 17:
                {
                    this.category0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.amount0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.inOrOut0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.description0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.isPocketMoney0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.date0 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element23 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 166 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element23).Click += this.edit_click;
                    #line default
                }
                break;
            case 24:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element24 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 167 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element24).Click += this.delete_click;
                    #line default
                }
                break;
            case 25:
                {
                    global::Windows.UI.Xaml.Controls.ListView element25 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 123 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)element25).ItemClick += this.accountItemClicked;
                    #line default
                }
                break;
            case 26:
                {
                    this.ExpenseList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 75 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ExpenseList).ItemClick += this.categoryItemClicked;
                    #line default
                }
                break;
            case 27:
                {
                    global::Windows.UI.Xaml.Controls.ListView element27 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 96 "..\..\..\AccountsListViewPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)element27).ItemClick += this.categoryItemClicked;
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
                    AccountsListViewPage_obj1_Bindings bindings = new AccountsListViewPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 28:
                {
                    global::Windows.UI.Xaml.Controls.Border element28 = (global::Windows.UI.Xaml.Controls.Border)target;
                    AccountsListViewPage_obj28_Bindings bindings = new AccountsListViewPage_obj28_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ShowMeMyMoney.Model.categoryItem) element28.DataContext);
                    element28.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element28, bindings);
                }
                break;
            case 30:
                {
                    global::Windows.UI.Xaml.Controls.Border element30 = (global::Windows.UI.Xaml.Controls.Border)target;
                    AccountsListViewPage_obj30_Bindings bindings = new AccountsListViewPage_obj30_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ShowMeMyMoney.Model.categoryItem) element30.DataContext);
                    element30.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element30, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

