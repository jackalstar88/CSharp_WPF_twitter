﻿using System.Windows;
using tweetz.core.Models;

namespace tweetz.core.Infrastructure
{
    public interface IWindowInteropService
    {
        void SetWindowPosition(Window window, WindowPosition windowPosition);

        WindowPosition GetWindowPosition(Window window);

        void PowerManagementRegistration(Window window, ISystemState systemState);
    }
}