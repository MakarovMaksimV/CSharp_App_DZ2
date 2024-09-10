using System;
namespace DZ2
{
	public interface IBitGateble
	{
        bool GetBitByIndex(byte index);
        void SetBitByIndex(byte index, bool value);
    }
}

