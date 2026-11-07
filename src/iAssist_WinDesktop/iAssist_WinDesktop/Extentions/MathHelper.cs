namespace iAssist_WinDesktop.Extentions {
    internal class MathHelper {
        /// <summary>
        /// Return a number n, min >= n >= max.
        /// If n is greater than max, then return to min.
        /// If n is less than min, then set to max.
        /// </summary>
        public static int CircularClamp(int n, int min, int max) {
            return n < min ? max : n > max ? min : n;
        }
    }
}
