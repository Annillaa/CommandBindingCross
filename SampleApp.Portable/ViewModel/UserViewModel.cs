//
//  Employee.cs
//
//  Author:
//       developer  
//
//  Copyright (c) 2017 (c) Varun R
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using MvvmCross.Core.ViewModels;

namespace SampleApp.Portable
{
    public class UserViewModel : MvxViewModel
    {
        MvxCommand _signInCommand;
        string _userName;
        string _password;
        int _id;
        bool _canExecute = false;

        public UserViewModel()
        {

        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        bool CanExecuteChanged()
        {
            return _canExecute;
        }

        public bool CanExecute
        {
            get
            {
                return _canExecute;
            }
            set
            {
                _canExecute = value;
                RaisePropertyChanged(() => CanExecute);
            }
        }


        public IMvxCommand SignInCommand
        {
            get
            {
                if (_signInCommand == null)
                {
                    _canExecute = true;
                    _signInCommand = new MvxCommand(OnSignIn, CanExecuteChanged);
                    RaisePropertyChanged(() => CanExecute);
                }
                return _signInCommand;
            }
        }

        void OnSignIn()
        {

        }

    }
}
