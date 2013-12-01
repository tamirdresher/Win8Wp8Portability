using System;
using System.Windows.Input;
using MixAndDi.Shared;

namespace MixAndDi.WP8.App
{
    public class LoginPageViewModel
    {
        private readonly IFacebookServices _facebookServices;
        private RelayCommand _loginToFacebookCmd;

        public LoginPageViewModel(IFacebookServices facebookServices)
        {
            _facebookServices = facebookServices;
        }

        public RelayCommand LoginToFacebookCommand
        {
            get
            {
                return _loginToFacebookCmd ??
                    (_loginToFacebookCmd = new RelayCommand(async () => await _facebookServices.Login()));
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        /// <summary>
        /// Initializes a new instance of the RelayCommand class that
        ///             can always execute.
        /// 
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">If the execute argument is null.</exception>
        public RelayCommand(Action execute)
            : this(execute, () => true)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelayCommand class.
        /// 
        /// </summary>
        /// <param name="execute">The execution logic.</param><param name="canExecute">The execution status logic.</param><exception cref="T:System.ArgumentNullException">If the execute argument is null.</exception>
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }



        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// 
        /// </summary>
        /// <param name="parameter">This parameter will always be ignored.</param>
        public virtual void Execute(object parameter)
        {
            _execute();
        }
        /// <summary>
        /// Occurs when changes occur that affect whether the command should execute.
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged;
    }
}