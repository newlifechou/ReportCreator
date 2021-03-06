/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:WpfReportCreator"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<WindowManager>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<UCTargetViewModel>();
            SimpleIoc.Default.Register<UCSampleViewModel>();
            SimpleIoc.Default.Register<UCVHPSelectViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public UCTargetViewModel UCTarget
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UCTargetViewModel>();
            }
        }

        public UCSampleViewModel UCSample
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UCSampleViewModel>();
            }
        } 
        
        public UCVHPSelectViewModel VHPSelect
        {
            get
            {
                return ServiceLocator.Current.GetInstance<UCVHPSelectViewModel>();
            }
        }
        
        
                  
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}