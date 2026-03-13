public static class FlickerFix
{
    public static void Enable(Control control)
    {
        typeof(Control)
            .GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
            ?.SetValue(control, true);
    }
}
