using Android.Content.Res;
using Android.Text;
using IntelliJ.Lang.Annotations;
using Java.Lang;
using Kotlin.Jvm.Internal;
using static Android.Content.Res.Resources;
using static Android.Graphics.BlurMaskFilter;
using static Android.Hardware.Camera;

namespace AlmostList.Client.Models.Properties.User
{
    public class UserOptions
    {
        public UserTitleLanguage TitleLanguage { get; set; }
        public bool DisplayAdultContent { get; set; } = false;
        public bool AiringNotifications { get; set; }
        public string? ProfileColor { get; set; }
        public List<NotificationOption>? NotificationOptions { get; set; }
        public string? Timezone { get; set; }
        public int? ActivityMergeTime { get; set; }
        public UserStaffNameLanguage StaffNameLanguage { get; set; }
        public bool RestrictMessagesToFollowing { get; set; }
        public List<ListActivityOption>? DisabledListActivity { get; set; }
    }
}