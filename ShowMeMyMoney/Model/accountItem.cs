﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeMyMoney.Model
{
    public class accountItem : INotifyPropertyChanged
    {
        private long _category;
        /*  用数字表示分类，这样分类可以改变名字； 
        需要另外维护一个分类表*/
        private DateTimeOffset _createDate;
        private double _amount;
        /* amount 均是正数，用变量inOrOut表示是收入还是支出*/
        private bool _isPocketMoney;
        /* 表明是否为私房钱 */
        private bool _inOrOut;
        /* 0 表示支出，1表示收入*/
        private string _description;
        /* 对该项记录的详细描述 */
        public string id { get; }


        /* 主码 */
        public accountItem(long category, DateTimeOffset date, double amount,
                            bool isPocketMoney, bool inOrOut, string description)
        {
            _category = category;
            _createDate = date;
            _amount = amount;
            _isPocketMoney = isPocketMoney;
            _inOrOut = inOrOut;
            _description = description;
            id =  Guid.NewGuid().ToString();

        }

        public accountItem(string id)
        {

            this.id = id;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            //PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public long category
        {
            get { return _category; }
            set
            {
                if (_category != value)
                {
                    _category = value;
                    RaisePropertyChanged("category");
                }
            }
        }

        public string description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged("description");
                }
            }
        }

        public DateTimeOffset createDate
        {
            get { return _createDate; }
            set
            {
                if (_createDate != value)
                {
                    _createDate = value;
                    RaisePropertyChanged("createDate");
                }
            }
        }

        public double amount
        {
            get { return _amount; }
            set
            {
                if (_amount != value)
                {
                    _amount = value;
                    RaisePropertyChanged("amount");
                }
            }
        }

        public bool isPocketMoney
        {
            get { return _isPocketMoney; }
            set
            {
                if (_isPocketMoney != value)
                {
                    _isPocketMoney = value;
                    RaisePropertyChanged("isPocketMoney");
                }
            }
        }

        public bool inOrOut
        {
            get { return _inOrOut; }
            set
            {
                if (_inOrOut != value)
                {
                    _inOrOut = value;
                    RaisePropertyChanged("inOrOut");
                }
            }
        }

    }
}
