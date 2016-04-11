﻿using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceTargetReport;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class UCTargetViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the UCTargetViewModel class.
        /// </summary>
        public UCTargetViewModel()
        {
            FillTargets(0,20);
            AddCommand = new RelayCommand(ActionAdd, CanAdd);
        }

        private void FillTargets(int skip,int take)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            Targets = new ObservableCollection<Target>(client.GetTargets(skip, take));
            client.Close();
        }

        private bool CanAdd()
        {
            return Service.Access.AccessState==Service.LogState.Pass;
        }

        private void ActionAdd()
        {
            throw new NotImplementedException();
        }

        public RelayCommand AddCommand { get; set; }

        private ObservableCollection<Target> targets;
        public ObservableCollection<Target> Targets
        {
            get { return targets; }
            set
            {
                if (targets == value)
                    return;
                targets = value;
                RaisePropertyChanged(() => Targets);
            }
        }


    }
}