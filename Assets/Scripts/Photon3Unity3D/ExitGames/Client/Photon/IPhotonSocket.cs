using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	public abstract class IPhotonSocket
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass40_0
		{
			public byte[] inBufferCopy;

			public _003C_003Ec__DisplayClass40_1 CS_0024_003C_003E8__locals1;

			internal void _003CHandleReceivedDatagram_003Eb__0()
			{
				CS_0024_003C_003E8__locals1._003C_003E4__this.peerBase.ReceiveIncomingCommands(inBufferCopy, CS_0024_003C_003E8__locals1.length);
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass40_1
		{
			public int length;

			public byte[] inBuffer;

			public IPhotonSocket _003C_003E4__this;

			internal void _003CHandleReceivedDatagram_003Eb__1()
			{
				_003C_003E4__this.peerBase.ReceiveIncomingCommands(inBuffer, length);
			}
		}

		protected internal PeerBase peerBase;

		protected readonly ConnectionProtocol Protocol;

		public bool PollReceive;

		protected IPhotonPeerListener Listener
		{
			get
			{
				return peerBase.Listener;
			}
		}

		protected internal int MTU
		{
			get
			{
				return peerBase.mtu;
			}
		}

		public PhotonSocketState State { get; protected set; }

		public bool Connected
		{
			get
			{
				return State == PhotonSocketState.Connected;
			}
		}

		public string ConnectAddress
		{
			get
			{
				return peerBase.ServerAddress;
			}
		}

		public string ServerAddress { get; protected set; }

		public int ServerPort { get; protected set; }

		public bool AddressResolvedAsIpv6 { get; protected internal set; }

		public string UrlProtocol { get; protected set; }

		public string UrlPath { get; protected set; }

		public IPhotonSocket(PeerBase peerBase)
		{
			if (peerBase == null)
			{
				throw new Exception("Can't init without peer");
			}
			Protocol = peerBase.usedProtocol;
			this.peerBase = peerBase;
		}

		public virtual bool Connect()
		{
			if (State != 0)
			{
				if ((int)peerBase.debugOut >= 1)
				{
					peerBase.Listener.DebugReturn(DebugLevel.ERROR, "Connect() failed: connection in State: " + State);
				}
				return false;
			}
			if (peerBase == null || Protocol != peerBase.usedProtocol)
			{
				return false;
			}
			string address;
			ushort port;
			string urlProtocol;
			string urlPath;
			if (!TryParseAddress(peerBase.ServerAddress, out address, out port, out urlProtocol, out urlPath))
			{
				if ((int)peerBase.debugOut >= 1)
				{
					peerBase.Listener.DebugReturn(DebugLevel.ERROR, "Failed parsing address: " + peerBase.ServerAddress);
				}
				return false;
			}
			ServerAddress = address;
			ServerPort = port;
			UrlProtocol = urlProtocol;
			UrlPath = urlPath;
			if ((int)peerBase.debugOut >= 5)
			{
				Listener.DebugReturn(DebugLevel.ALL, "IPhotonSocket.Connect() " + ServerAddress + ":" + ServerPort + " this.Protocol: " + Protocol);
			}
			return true;
		}

		public abstract bool Disconnect();

		public abstract PhotonSocketError Send(byte[] data, int length);

		public abstract PhotonSocketError Receive(out byte[] data);

		public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused)
		{
			_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_1();
			_003C_003Ec__DisplayClass40_._003C_003E4__this = this;
			_003C_003Ec__DisplayClass40_.length = length;
			_003C_003Ec__DisplayClass40_.inBuffer = inBuffer;
			if (peerBase.NetworkSimulationSettings.IsSimulationEnabled)
			{
				if (willBeReused)
				{
					_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_2 = new _003C_003Ec__DisplayClass40_0();
					_003C_003Ec__DisplayClass40_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass40_;
					_003C_003Ec__DisplayClass40_2.inBufferCopy = new byte[_003C_003Ec__DisplayClass40_2.CS_0024_003C_003E8__locals1.length];
					Buffer.BlockCopy(_003C_003Ec__DisplayClass40_2.CS_0024_003C_003E8__locals1.inBuffer, 0, _003C_003Ec__DisplayClass40_2.inBufferCopy, 0, _003C_003Ec__DisplayClass40_2.CS_0024_003C_003E8__locals1.length);
					peerBase.ReceiveNetworkSimulated(_003C_003Ec__DisplayClass40_2._003CHandleReceivedDatagram_003Eb__0);
				}
				else
				{
					peerBase.ReceiveNetworkSimulated(_003C_003Ec__DisplayClass40_._003CHandleReceivedDatagram_003Eb__1);
				}
			}
			else
			{
				peerBase.ReceiveIncomingCommands(_003C_003Ec__DisplayClass40_.inBuffer, _003C_003Ec__DisplayClass40_.length);
			}
		}

		public bool ReportDebugOfLevel(DebugLevel levelOfMessage)
		{
			return (int)peerBase.debugOut >= (int)levelOfMessage;
		}

		public void EnqueueDebugReturn(DebugLevel debugLevel, string message)
		{
			peerBase.EnqueueDebugReturn(debugLevel, message);
		}

		protected internal void HandleException(StatusCode statusCode)
		{
			State = PhotonSocketState.Disconnecting;
			peerBase.EnqueueStatusCallback(statusCode);
			peerBase.EnqueueActionForDispatch(_003CHandleException_003Eb__43_0);
		}

		protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath)
		{
			address = string.Empty;
			port = 0;
			urlProtocol = string.Empty;
			urlPath = string.Empty;
			string text = url;
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			int num = text.IndexOf("://");
			if (num >= 0)
			{
				urlProtocol = text.Substring(0, num);
				text = text.Substring(num + 3);
			}
			num = text.IndexOf("/");
			if (num >= 0)
			{
				urlPath = text.Substring(num);
				text = text.Substring(0, num);
			}
			num = text.LastIndexOf(':');
			if (num < 0)
			{
				return false;
			}
			if (text.IndexOf(':') != num && (!text.Contains("[") || !text.Contains("]")))
			{
				return false;
			}
			address = text.Substring(0, num);
			string s = text.Substring(num + 1);
			return ushort.TryParse(s, out port);
		}

		protected internal bool IsIpv6SimpleCheck(IPAddress address)
		{
			return address != null && address.ToString().Contains(":");
		}

		protected internal static IPAddress GetIpAddress(string address)
		{
			IPAddress address2 = null;
			if (IPAddress.TryParse(address, out address2))
			{
				return address2;
			}
			IPHostEntry hostEntry = Dns.GetHostEntry(address);
			IPAddress[] addressList = hostEntry.AddressList;
			IPAddress[] array = addressList;
			foreach (IPAddress iPAddress in array)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetworkV6)
				{
					return iPAddress;
				}
				if (address2 == null && iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					address2 = iPAddress;
				}
			}
			return address2;
		}

		[CompilerGenerated]
		private void _003CHandleException_003Eb__43_0()
		{
			peerBase.Disconnect();
		}
	}
}
