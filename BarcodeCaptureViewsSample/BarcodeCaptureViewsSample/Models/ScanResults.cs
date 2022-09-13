using System;

namespace BarcodeCaptureViewsSample.Models
{
    public class ScanResult : IEquatable<ScanResult>
    {
        public string Symbology { get; }
        public string Data { get; }

        public ScanResult(string symbology, string data)
        {
            this.Symbology = symbology;
            this.Data = data;
        }

        public bool Equals(ScanResult other)
        {
            if (other == null)
            {
                return false;
            }

            return this.GetHashCode() == other.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj as ScanResult) != null && this.Equals((ScanResult)obj);
        }

        public override int GetHashCode()
        {
            return this.Symbology.GetHashCode() ^ this.Data.GetHashCode();
        }
    }
}