namespace RefactorView.Infraestructure.Html
{
    public struct Size
    {
        public Size(byte lg,byte md,byte sm,byte xs)
        {
            this.Lg = lg;
            this.Md = md;
            this.Sm = sm;
            this.Xs = xs;
        }        
        public byte Lg { get; set; }
        public byte Md { get; set; }
        public byte Sm { get; set; }
        public byte Xs { get; set; }

        public override string ToString()
        {
            return $"col-lg-{Lg} col-md-{Md} col-sm-{Sm} col-xs-{Xs}";
        }

        private byte CalcComplement(byte val)
        {
            if (val == 12) return 12;
            return (byte)(12 - val);
        }
        public Size GetComplement()
        {
            return new Size(CalcComplement(Lg), CalcComplement(Md), CalcComplement(Sm), CalcComplement(Xs));
        }
    }
}