﻿using Jamesnet.Wpf.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public class ExplorerViewModel : ObservableBase
    {
        public string DownloadDirectory { get; init; }
        public string DocumentsDirectory { get; init; }
        public string PicturesDirectory { get; init; }

        public ExplorerViewModel(DirectoryManager directoryManager)
        {
            DownloadDirectory = directoryManager.DownloadDirectory;
            DocumentsDirectory = directoryManager.DocumentsDirectory;
            PicturesDirectory = directoryManager.PicturesDirectory;
        }
    }
}
