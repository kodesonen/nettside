using System;

namespace WebApp.Helpers
{
    public static class StatusMessage
    {
        public static string Success(string header, string message)
        {
            return $"<div class='success_label'><div class='label_text'><h3><strong>{header}</strong> {message}</h3></div></div>";
        }

        public static string Error(string header, string message)
        {
            return $"<div class='error_label'><div class='label_text'><h3><strong>{header}</strong> {message}</h3></div></div>";
        }

        public static string Warning(string header, string message)
        {
            return $"<div class='warning_label'><div class='label_text'><h3><strong>{header}</strong> {message}</h3></div></div>"; 
        }
    }
}
