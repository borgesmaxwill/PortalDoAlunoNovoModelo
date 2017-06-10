using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trabalhoIHC.Controllers
{
    public class MessagerBaseController : Controller
    {
        public MessagerBaseController()
        {
            Toastr = new Toastr();
        }
        public Toastr Toastr { get; set; }

        public ToastMessage AddToastMessage(string title, string message, ToastType toastType, ToastOption options = null)
        {
            return Toastr.AddToastMessage(title, message, toastType, options);
        }
    }
    
    [Serializable]
    public class Toastr
    {
        public bool ShowNewestOnTop { get; set; }
        public bool ShowCloseButton { get; set; }
        public List<ToastMessage> ToastMessages { get; set; }

        public ToastMessage AddToastMessage(string title, string message, ToastType toastType, ToastOption option)
        {
            var toast = new ToastMessage(title, message, toastType, option);
            ToastMessages.Add(toast);
            return toast;
        }

        public Toastr()
        {
            ToastMessages = new List<ToastMessage>();
            ShowNewestOnTop = false;
            ShowCloseButton = false;
        }
    }

    [Serializable]
    public class ToastMessage
    {
        private ToastOption _toastOptions;

        [JsonConstructor]
        public ToastMessage(ToastOption options)
        {
            _toastOptions = options;
            ToastOptionsJson = JsonConvert.SerializeObject(ToastOptions, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }

        public ToastMessage(string message, string title, ToastType toasType, ToastOption options)
        {
            this.Message = message;
            this.Title = title;
            this.ToastType = toasType;
            this.ToastOptions = options;
            ToastOptionsJson = JsonConvert.SerializeObject(ToastOptions, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public ToastType ToastType { get; set; }
        public bool IsSticky { get; set; }
        public ToastOption ToastOptions
        {
            get
            {
                return _toastOptions;
            }
            set
            {
                if (value != null)
                {
                    this._toastOptions = value;
                }
            }
        }

        public string ToastOptionsJson;
    }

    public class ToastOption
    {
        public bool? TapToDismiss { get; set; }
        public string ToastClass { get; set; }
        public string ContainerId { get; set; }
        public bool? Debug { get; set; }
        public string ShowMethod { get; set; }
        public int? ShowDuration { get; set; }
        public string ShowEasing { get; set; }
        public string OnShown { get; set; }
        public string HideMethod { get; set; }
        public int? HideDuration { get; set; }
        public string HideEasing { get; set; }
        public string OnHidden { get; set; }
        public bool? CloseMethod { get; set; }
        public bool? CloseDuration { get; set; }
        public bool? CloseEasing { get; set; }
        public bool? CloseOnHover { get; set; }
        public int? ExtendedTimeOut { get; set; }
        /// <summary>
        /// Use the <see cref="NToastNotify.Constants.IconClasses"/> to set the available values
        /// </summary>
        public string IconClass { get; set; }
        /// <summary>
        /// Use the <see cref="NToastNotify.Constants.ToastPositions"/> to set the available values
        /// </summary>
        public string PositionClass { get; set; }
        public int? TimeOut { get; set; }
        public string TitleClass { get; set; }
        public string MessageClass { get; set; }
        public bool? EscapeHtml { get; set; }
        public string Target { get; set; }
        public string CloseHtml { get; set; }
        public string CloseClass { get; set; }
        public bool? NewestOnTop { get; set; }
        public bool? PreventDuplicates { get; set; }
        public bool? ProgressBar { get; set; }
        public bool? Rtl { get; set; }
        public bool? CloseButton { get; set; }
        public string Onclick { get; set; }

        public static string DefaultsJson = JsonConvert.SerializeObject(Defaults, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });

        //visite o site abaixo para visualizar como customizar suas mensagens
        //http://codeseven.github.io/toastr/demo.html
        public static ToastOption Defaults
        {
            get
            {
                return new ToastOption()
                {
                    TapToDismiss = true,
                    ToastClass = "toast",
                    ContainerId = "toast-container",
                    Debug = false,
                    ShowMethod = "fadeIn",
                    ShowDuration = 300,
                    ShowEasing = "swing",
                    HideMethod = "fadeOut",
                    HideDuration = 1000,
                    HideEasing = "linear",
                    CloseMethod = false,
                    CloseDuration = false,
                    CloseEasing = false,
                    CloseOnHover = true,
                    ExtendedTimeOut = 1000,
                    IconClass = IconClasses.Info,
                    PositionClass = ToastPositions.TopRight,
                    TimeOut = 5000,
                    TitleClass = "toast-title",
                    MessageClass = "toast-message",
                    EscapeHtml = false,
                    Target = "body",
                    CloseHtml = "<button type='button'>&times;</button>",
                    CloseClass = "toast-close-button",
                    NewestOnTop = true,
                    PreventDuplicates = false,
                    ProgressBar = true,
                    Rtl = false,
                    CloseButton = true
                };


            }
        }
    }

    public enum ToastType
    {
        Error,
        Info,
        Success,
        Warning
    }

    public class ToastPositions
    {
        public const string TopRight = "toast-top-right";
        public const string BottomRight = "toast-bottom-right";
        public const string BottomLeft = "toast-bottom-left";
        public const string TopLeft = "toast-top-left";
        public const string TopFullWidth = "toast-top-full-width";
        public const string BottomFullWidth = "toast-bottom-full-width";
        public const string TopCenter = "toast-top-center";
        public const string BottomCenter = "toast-bottom-center";
    }

    public class IconClasses
    {
        public const string Error = "toast-error";
        public const string Info = "toast-info";
        public const string Success = "toast-success";
        public const string Warning = "toast-warning";
    }
}