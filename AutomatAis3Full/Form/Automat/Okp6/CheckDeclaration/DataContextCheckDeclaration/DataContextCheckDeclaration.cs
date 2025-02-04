﻿using AutomatAis3Full.Config;
using LibraryCommandPublic.TestAutoit.Okp6.JournalDoc;
using Prism.Commands;
using ViewModelLib.ModelTestAutoit.PublicModel.ButtonStartAutomat;

namespace AutomatAis3Full.Form.Automat.Okp6.CheckDeclaration.DataContextCheckDeclaration
{
   public class DataContextCheckDeclaration
    {
        /// <summary>
        /// Кнопка старт
        /// </summary>
        public StatusButtonMethod StartButton { get; }

        /// <summary>
        /// Дата контекст
        /// </summary>
        public DataContextCheckDeclaration()
        {
            var docStart = new AutoJournalDoc();
            StartButton = new StatusButtonMethod
            {
                Button = { Command = new DelegateCommand(() => { docStart.StartCheckDeclaration(StartButton, ConfigFile.PathTemp); }) }
            };
        }

    }
}
