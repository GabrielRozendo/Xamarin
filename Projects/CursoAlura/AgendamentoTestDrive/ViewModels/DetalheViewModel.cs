﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net.Http;

namespace AgendamentoTestDrive
{
	public class DetalheViewModel : INotifyPropertyChanged
	{
		public Veiculo Veiculo { get; set; }

		public bool TemFreioAbs
		{
			get { return Veiculo.TemFreioAbs; }

			set
			{
				Veiculo.TemFreioAbs = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public bool TemArCondicionado
		{
			get { return Veiculo.TemArCondicionado; }

			set
			{
				Veiculo.TemArCondicionado = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public bool TemMp3Player
		{
			get { return Veiculo.TemMp3Player; }

			set
			{
				Veiculo.TemMp3Player = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public string ValorTotal
		{
			get { return Veiculo.PrecoTotalFormatado; }
		}


		public DetalheViewModel(Veiculo veiculo)
		{
			this.Veiculo = veiculo;
			ProximoCommand = new Command(() =>
			{
				MessagingCenter.Send(Veiculo, "Proximo");
			});
		}


		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string name = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		public ICommand ProximoCommand { get; set; }
	}
}
