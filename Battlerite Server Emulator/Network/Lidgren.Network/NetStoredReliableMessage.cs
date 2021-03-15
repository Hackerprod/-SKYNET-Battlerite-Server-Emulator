namespace Lidgren.Network
{
	internal struct NetStoredReliableMessage
	{
		public int NumSent;

		public float LastSent;

		public NetOutgoingMessage Message;

		public void Reset()
		{
			NumSent = 0;
			LastSent = 0f;
			Message = null;
		}
	}
}
