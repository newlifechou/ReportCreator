﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceSampleReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/11 9:24:46
*/
namespace WpfReportCreator.ViewModel
{
    public class UCSampleViewModel : ViewModelBase
    {

        public UCSampleViewModel()
        {
            InitalProperties();
            InitialCommands();
        }

        #region 初始化区域
        private void InitalProperties()
        {

        }
        private void InitialCommands()
        {

        }
        #endregion

        #region 属性区域
        private string searchLot;
        public string SearchLot
        {
            get { return searchLot; }
            set
            {
                if (searchLot == value)
                    return;
                searchLot = value;
                RaisePropertyChanged(() => SearchLot);
            }
        }
        private string searchCustomer;
        public string SearchCustomer
        {
            get { return searchCustomer; }
            set
            {
                if (searchCustomer == value)
                    return;
                searchCustomer = value;
                RaisePropertyChanged(() => SearchCustomer);
            }
        }
        private ObservableCollection<Sample> samples;
        public ObservableCollection<Sample> Samples
        {
            get { return samples; }
            set
            {
                if (samples == value)
                    return;
                samples = value;
                RaisePropertyChanged(() => Samples);
            }
        }

        #endregion

        #region 命令区域
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand<Sample> EditCommand { get; private set; }
        public RelayCommand<Sample> DeleteCommand { get; private set; }
        public RelayCommand SearchCommand { get; private set; }
        public RelayCommand GetAllCommand { get; private set; }

        #endregion
        #region 分页属性和命令
        private int pageIndex;
        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                if (pageIndex == value)
                    return;
                pageIndex = value;
                RaisePropertyChanged(() => PageIndex);
            }
        }
        private int pageSize;
        public int PageSize
        {
            get { return pageSize; }
            set
            {
                if (pageSize == value)
                    return;
                pageSize = value;
                RaisePropertyChanged(() => PageSize);
            }
        }
        private int recordCount;
        public int RecordCount
        {
            get { return recordCount; }
            set
            {
                if (recordCount == value)
                    return;
                recordCount = value;
                RaisePropertyChanged(() => RecordCount);
            }
        }
        public RelayCommand PageCommand { get; private set; }
        #endregion #region 分页
    }
}
