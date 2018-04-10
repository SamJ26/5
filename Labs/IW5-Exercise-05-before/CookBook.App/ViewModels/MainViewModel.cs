﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using CookBook.App.Commands;
using CookBook.BL;
using CookBook.BL.Messages;

namespace CookBook.App.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IMessenger messenger;

        public string Name { get; set; } = "Nenacteno";

        public MainViewModel(IMessenger messenger)
        {
            this.messenger = messenger;
        }

        public void OnLoad()
        {
        }
    }
}