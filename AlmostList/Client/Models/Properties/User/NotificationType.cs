﻿using static Android.Content.Res.Resources;
using static Android.InputMethodServices.Keyboard;
using static Android.Security.Identity.CredentialDataResult;

namespace AlmostList.Client.Models.Properties.User
{
    public enum NotificationType
    {
        ACTIVITY_MESSAGE,
        ACTIVITY_REPLY,
        FOLLOWING,
        ACTIVITY_MENTION,
        THREAD_COMMENT_MENTION,
        THREAD_SUBSCRIBED,
        THREAD_COMMENT_REPLY,
        AIRING,
        ACTIVITY_LIKE,
        ACTIVITY_REPLY_LIKE,
        THREAD_LIKE,
        THREAD_COMMENT_LIKE,
        ACTIVITY_REPLY_SUBSCRIBED,
        RELATED_MEDIA_ADDITION,
        MEDIA_DATA_CHANGE,
        MEDIA_MERGE,
        MEDIA_DELETION
    }
}