using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ListaMvvm.ViewModel
{
    public class ViewModel: BindableObject
    {

		protected bool SetProperty<T>(ref T backingStore, 
			T value,
			[CallerMemberName] string propertyName = "",
			Action onChanged = null)
		{
			backingStore = value;
			onChanged?.Invoke();
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}
