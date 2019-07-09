namespace UBS_TransformService.Services
{
    interface ICurrencyTransform
    {
        string Humanize(int ammount);
        string Humanize(double ammount);
    }
}
