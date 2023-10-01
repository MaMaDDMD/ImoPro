using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Imo.Model
{
    public partial class imofriendsContext : DbContext
    {
        public imofriendsContext()
        {
        }

        public imofriendsContext(DbContextOptions<imofriendsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<AndroidMetadatum> AndroidMetadata { get; set; } = null!;
        public virtual DbSet<BgPreference> BgPreferences { get; set; } = null!;
        public virtual DbSet<BigGroup> BigGroups { get; set; } = null!;
        public virtual DbSet<BigGroupMessage> BigGroupMessages { get; set; } = null!;
        public virtual DbSet<BigGroupMessageTranslation> BigGroupMessageTranslations { get; set; } = null!;
        public virtual DbSet<Blist> Blists { get; set; } = null!;
        public virtual DbSet<BubbleInfo> BubbleInfos { get; set; } = null!;
        public virtual DbSet<CachedUpload> CachedUploads { get; set; } = null!;
        public virtual DbSet<CallInterceptRecord> CallInterceptRecords { get; set; } = null!;
        public virtual DbSet<CallOutHistory> CallOutHistories { get; set; } = null!;
        public virtual DbSet<CallTimestamp> CallTimestamps { get; set; } = null!;
        public virtual DbSet<CallsOnly> CallsOnlies { get; set; } = null!;
        public virtual DbSet<Channel> Channels { get; set; } = null!;
        public virtual DbSet<ChannelCertInfo> ChannelCertInfos { get; set; } = null!;
        public virtual DbSet<ChannelPostCache> ChannelPostCaches { get; set; } = null!;
        public virtual DbSet<ChannelPostDetail> ChannelPostDetails { get; set; } = null!;
        public virtual DbSet<ChannelProfilePage> ChannelProfilePages { get; set; } = null!;
        public virtual DbSet<ChannelSalat> ChannelSalats { get; set; } = null!;
        public virtual DbSet<ChatHistoryMsg> ChatHistoryMsgs { get; set; } = null!;
        public virtual DbSet<ChatsNew> ChatsNews { get; set; } = null!;
        public virtual DbSet<DeeplinkPush> DeeplinkPushes { get; set; } = null!;
        public virtual DbSet<EmojiKeyword> EmojiKeywords { get; set; } = null!;
        public virtual DbSet<EmojiKeywordsInfo> EmojiKeywordsInfos { get; set; } = null!;
        public virtual DbSet<EncryptChat> EncryptChats { get; set; } = null!;
        public virtual DbSet<EncryptDeviceIdentify> EncryptDeviceIdentifies { get; set; } = null!;
        public virtual DbSet<EncryptSecretKey> EncryptSecretKeys { get; set; } = null!;
        public virtual DbSet<FavoriteExpression> FavoriteExpressions { get; set; } = null!;
        public virtual DbSet<FileAssistant> FileAssistants { get; set; } = null!;
        public virtual DbSet<FileTransfer> FileTransfers { get; set; } = null!;
        public virtual DbSet<Friend> Friends { get; set; } = null!;
        public virtual DbSet<FriendRingback> FriendRingbacks { get; set; } = null!;
        public virtual DbSet<FriendSetting> FriendSettings { get; set; } = null!;
        public virtual DbSet<HdVideo> HdVideos { get; set; } = null!;
        public virtual DbSet<HdVideo2> HdVideo2s { get; set; } = null!;
        public virtual DbSet<ImoLive> ImoLives { get; set; } = null!;
        public virtual DbSet<ImoPhonebook> ImoPhonebooks { get; set; } = null!;
        public virtual DbSet<LocalRecommendPhonebookContact> LocalRecommendPhonebookContacts { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MyFile> MyFiles { get; set; } = null!;
        public virtual DbSet<NearbyLog> NearbyLogs { get; set; } = null!;
        public virtual DbSet<NewContact> NewContacts { get; set; } = null!;
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; } = null!;
        public virtual DbSet<PhonebookEntry> PhonebookEntries { get; set; } = null!;
        public virtual DbSet<PixelBackup> PixelBackups { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PrivacyEncryptDevice> PrivacyEncryptDevices { get; set; } = null!;
        public virtual DbSet<RecommendPhonebookContact> RecommendPhonebookContacts { get; set; } = null!;
        public virtual DbSet<Relationship> Relationships { get; set; } = null!;
        public virtual DbSet<RelationshipMessage> RelationshipMessages { get; set; } = null!;
        public virtual DbSet<SecretChat> SecretChats { get; set; } = null!;
        public virtual DbSet<SecretKey> SecretKeys { get; set; } = null!;
        public virtual DbSet<SecretMessage> SecretMessages { get; set; } = null!;
        public virtual DbSet<SecretSeq> SecretSeqs { get; set; } = null!;
        public virtual DbSet<Sticker> Stickers { get; set; } = null!;
        public virtual DbSet<StickersPack> StickersPacks { get; set; } = null!;
        public virtual DbSet<Story> Stories { get; set; } = null!;
        public virtual DbSet<StorySendDraft> StorySendDrafts { get; set; } = null!;
        public virtual DbSet<TrackedInvite> TrackedInvites { get; set; } = null!;
        public virtual DbSet<UserChannel> UserChannels { get; set; } = null!;
        public virtual DbSet<UserChannelPost> UserChannelPosts { get; set; } = null!;
        public virtual DbSet<VideoMessage> VideoMessages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\db\\imofriends.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("account_type");

                entity.HasIndex(e => e.Buid, "IX_account_type_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AccountType1).HasColumnName("account_type");

                entity.Property(e => e.Buid).HasColumnName("buid");
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("album");

                entity.HasIndex(e => new { e.Buid, e.Album1, e.ObjectId }, "IX_album_buid_album_object_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Album1).HasColumnName("album");

                entity.Property(e => e.AlbumsNumbers).HasColumnName("albums_numbers");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.OriginalId).HasColumnName("original_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<AndroidMetadatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("android_metadata");

                entity.Property(e => e.Locale).HasColumnName("locale");
            });

            modelBuilder.Entity<BgPreference>(entity =>
            {
                entity.ToTable("bg_preference");

                entity.HasIndex(e => e.Bgid, "IX_bg_preference_bgid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AudioMessageOnly).HasColumnName("audio_message_only");

                entity.Property(e => e.Bgid).HasColumnName("bgid");

                entity.Property(e => e.DisableAudioMessage).HasColumnName("disable_audio_message");

                entity.Property(e => e.DisableChannelMessage)
                    .HasColumnName("disable_channel_message")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DisableGroupCardMessage).HasColumnName("disable_group_card_message");
            });

            modelBuilder.Entity<BigGroup>(entity =>
            {
                entity.ToTable("big_group");

                entity.HasIndex(e => e.Bgid, "IX_big_group_bgid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.Bgid).HasColumnName("bgid");

                entity.Property(e => e.ClosedAnnouncementId)
                    .HasColumnName("closed_announcement_id")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.ExInfo).HasColumnName("ex_info");

                entity.Property(e => e.GroupType)
                    .HasColumnName("group_type")
                    .HasDefaultValueSql("\"normal\"");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IsFolded)
                    .HasColumnName("is_folded")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsInvisibleFriend)
                    .HasColumnName("is_invisible_friend")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMuted)
                    .HasColumnName("is_muted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPrivate)
                    .HasColumnName("is_private")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPublic)
                    .HasColumnName("is_public")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastMsgSeq).HasColumnName("last_msg_seq");

                entity.Property(e => e.LastReadMsgSeq).HasColumnName("last_read_msg_seq");

                entity.Property(e => e.MillsToJoin)
                    .HasColumnType("LONG")
                    .HasColumnName("mills_to_join")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MillsToPromoted)
                    .HasColumnType("LONG")
                    .HasColumnName("mills_to_promoted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovedToCommunityMember)
                    .HasColumnName("moved_to_community_member")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumUnread).HasColumnName("num_unread");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.ShortId).HasColumnName("short_id");

                entity.Property(e => e.SuperShortId).HasColumnName("super_short_id");
            });

            modelBuilder.Entity<BigGroupMessage>(entity =>
            {
                entity.ToTable("big_group_message");

                entity.HasIndex(e => new { e.Bgid, e.Timestamp, e.MsgSeq }, "IX_big_group_message_bgid_timestamp_msg_seq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ActiveTime).HasColumnName("active_time");

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.AtMe)
                    .HasColumnName("at_me")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bgid).HasColumnName("bgid");

                entity.Property(e => e.BubbleId).HasColumnName("bubble_id");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.ImdataType).HasColumnName("imdata_type");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.MessageTranslationInfo).HasColumnName("message_translation_info");

                entity.Property(e => e.MessageType).HasColumnName("message_type");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.MsgSeq).HasColumnName("msg_seq");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.UserIcon).HasColumnName("user_icon");

                entity.Property(e => e.UserNickname).HasColumnName("user_nickname");

                entity.Property(e => e.UserRole).HasColumnName("user_role");
            });

            modelBuilder.Entity<BigGroupMessageTranslation>(entity =>
            {
                entity.ToTable("big_group_message_translation");

                entity.HasIndex(e => new { e.Bgid, e.Timestamp, e.MsgSeq }, "IX_big_group_message_translation_bgid_timestamp_msg_seq")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Bgid).HasColumnName("bgid");

                entity.Property(e => e.MessageTranslationInfo).HasColumnName("message_translation_info");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.MsgSeq).HasColumnName("msg_seq");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Blist>(entity =>
            {
                entity.ToTable("blist");

                entity.HasIndex(e => new { e.Blistid, e.Buid }, "IX_blist_blistid_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Blistid).HasColumnName("blistid");

                entity.Property(e => e.Buid).HasColumnName("buid");
            });

            modelBuilder.Entity<BubbleInfo>(entity =>
            {
                entity.ToTable("bubble_info");

                entity.HasIndex(e => new { e.BubbleId, e.Type }, "IX_bubble_info_bubble_id_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.BackgroundColor).HasColumnName("background_color");

                entity.Property(e => e.Bgid).HasColumnName("bgid");

                entity.Property(e => e.BubbleId).HasColumnName("bubble_id");

                entity.Property(e => e.BubbleType).HasColumnName("bubble_type");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LabelImage).HasColumnName("label_image");

                entity.Property(e => e.PreviewImage).HasColumnName("preview_image");

                entity.Property(e => e.ReceiveImage).HasColumnName("receive_image");

                entity.Property(e => e.SendImage).HasColumnName("send_image");

                entity.Property(e => e.TextColor).HasColumnName("text_color");

                entity.Property(e => e.Tip).HasColumnName("tip");

                entity.Property(e => e.TopFloorMaskTransparency).HasColumnName("top_floor_mask_transparency");

                entity.Property(e => e.TopFloorTextColor).HasColumnName("top_floor_text_color");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CachedUpload>(entity =>
            {
                entity.ToTable("cached_uploads");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Md5Hash).HasColumnName("md5_hash");

                entity.Property(e => e.ServerId).HasColumnName("server_id");

                entity.Property(e => e.UploadTimestamp).HasColumnName("upload_timestamp");
            });

            modelBuilder.Entity<CallInterceptRecord>(entity =>
            {
                entity.ToTable("call_intercept_record");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.ChatType).HasColumnName("chat_type");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<CallOutHistory>(entity =>
            {
                entity.ToTable("call_out_history");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Normalized).HasColumnName("normalized");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Stat).HasColumnName("stat");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<CallTimestamp>(entity =>
            {
                entity.ToTable("call_timestamps");

                entity.HasIndex(e => e.Buid, "IX_call_timestamps_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<CallsOnly>(entity =>
            {
                entity.ToTable("calls_only");

                entity.HasIndex(e => new { e.Buid, e.CallType, e.Timestamp }, "IX_calls_only_buid_call_type_timestamp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.CallType).HasColumnName("call_type");

                entity.Property(e => e.ChatType).HasColumnName("chat_type");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("channel");

                entity.HasIndex(e => e.ChannelId, "IX_channel_channel_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IsBlocked).HasColumnName("is_blocked");

                entity.Property(e => e.IsFolded).HasColumnName("is_folded");

                entity.Property(e => e.IsMuted).HasColumnName("is_muted");

                entity.Property(e => e.IsSubscribe)
                    .HasColumnName("is_subscribe")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShareEnabled)
                    .HasColumnName("share_enabled")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShareId).HasColumnName("share_id");

                entity.Property(e => e.UnsubscribeEnabled)
                    .HasColumnName("unsubscribe_enabled")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ChannelCertInfo>(entity =>
            {
                entity.ToTable("channel_cert_info");

                entity.HasIndex(e => e.CertificationId, "IX_channel_cert_info_certification_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.JsonResult).HasColumnName("json_result");
            });

            modelBuilder.Entity<ChannelPostCache>(entity =>
            {
                entity.ToTable("channel_post_cache");

                entity.HasIndex(e => new { e.ChannelId, e.PostId, e.Timestamp }, "IX_channel_post_cache_channel_id_post_id_timestamp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Fake)
                    .HasColumnName("fake")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IsAck)
                    .HasColumnName("is_ack")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPlayed)
                    .HasColumnName("is_played")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogInfo).HasColumnName("log_info");

                entity.Property(e => e.MessageType)
                    .HasColumnName("message_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewState)
                    .HasColumnName("new_state")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostInfo).HasColumnName("post_info");

                entity.Property(e => e.PostInsertTimestamp)
                    .HasColumnName("post_insert_timestamp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostType).HasColumnName("post_type");

                entity.Property(e => e.SendState)
                    .HasColumnName("send_state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("INTERGER")
                    .HasColumnName("timestamp");

                entity.Property(e => e.TimestampNano)
                    .HasColumnType("INTERGER")
                    .HasColumnName("timestamp_nano");
            });

            modelBuilder.Entity<ChannelPostDetail>(entity =>
            {
                entity.ToTable("channel_post_detail");

                entity.HasIndex(e => new { e.ChannelId, e.PostId }, "IX_channel_post_detail_channel_id_post_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.FavoriteNum)
                    .HasColumnType("INTERGER")
                    .HasColumnName("favorite_num");

                entity.Property(e => e.HasFavorite)
                    .HasColumnType("INTERGER")
                    .HasColumnName("has_favorite")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.SourceChannelId).HasColumnName("source_channel_id");

                entity.Property(e => e.SourcePostId).HasColumnName("source_post_id");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("INTERGER")
                    .HasColumnName("update_time");

                entity.Property(e => e.ViewNum)
                    .HasColumnType("INTERGER")
                    .HasColumnName("view_num");
            });

            modelBuilder.Entity<ChannelProfilePage>(entity =>
            {
                entity.ToTable("channel_profile_page");

                entity.HasIndex(e => e.ChannelId, "IX_channel_profile_page_channel_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.JsonResult).HasColumnName("json_result");
            });

            modelBuilder.Entity<ChannelSalat>(entity =>
            {
                entity.ToTable("channel_salat");

                entity.HasIndex(e => new { e.ChannelId, e.SeqId, e.RecordDate }, "IX_channel_salat_channel_id_seq_id_record_date")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.PostType).HasColumnName("post_type");

                entity.Property(e => e.RecordCity).HasColumnName("record_city");

                entity.Property(e => e.RecordCount)
                    .HasColumnName("record_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.RecordDate).HasColumnName("record_date");

                entity.Property(e => e.SeqId).HasColumnName("seq_id");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<ChatHistoryMsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("chat_history_msg");

                entity.HasIndex(e => e.ConvId, "chat_history_msg_conv_id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.ConvId).HasColumnName("conv_id");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.Msg).HasColumnName("msg");

                entity.Property(e => e.MsgSeq).HasColumnName("msg_seq");

                entity.Property(e => e.TimestampNano).HasColumnName("timestamp_nano");
            });

            modelBuilder.Entity<ChatsNew>(entity =>
            {
                entity.ToTable("chats_new");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ActiveTimestamp).HasColumnName("active_timestamp");

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.ChatType).HasColumnName("chat_type");

                entity.Property(e => e.HasUnreadAtMessage)
                    .HasColumnName("has_unread_at_message")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IsFolded).HasColumnName("is_folded");

                entity.Property(e => e.IsInvisibleFriend)
                    .HasColumnName("is_invisible_friend")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPrivate)
                    .HasColumnName("is_private")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.LastMessageType)
                    .HasColumnName("last_message_type")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.RelationChatSourceType).HasColumnName("relation_chat_source_type");

                entity.Property(e => e.RowType).HasColumnName("row_type");

                entity.Property(e => e.StickyTopTimestamp).HasColumnName("sticky_top_timestamp");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<DeeplinkPush>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deeplink_push");

                entity.HasIndex(e => new { e.SeqId, e.MsgType, e.ContentId }, "IX_deeplink_push_seq_id_msg_type_content_id")
                    .IsUnique();

                entity.Property(e => e.Clicked).HasColumnName("clicked");

                entity.Property(e => e.ContentId).HasColumnName("content_id");

                entity.Property(e => e.MsgType).HasColumnName("msg_type");

                entity.Property(e => e.SeqId).HasColumnName("seq_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<EmojiKeyword>(entity =>
            {
                entity.ToTable("emoji_keywords");

                entity.HasIndex(e => new { e.LangCode, e.Keyword, e.Emoji }, "IX_emoji_keywords_lang_code_keyword_emoji")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Emoji).HasColumnName("emoji");

                entity.Property(e => e.Keyword).HasColumnName("keyword");

                entity.Property(e => e.LangCode).HasColumnName("lang_code");
            });

            modelBuilder.Entity<EmojiKeywordsInfo>(entity =>
            {
                entity.ToTable("emoji_keywords_info");

                entity.HasIndex(e => e.LangCode, "IX_emoji_keywords_info_lang_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.LangCode).HasColumnName("lang_code");

                entity.Property(e => e.ServerTs).HasColumnName("server_ts");

                entity.Property(e => e.UpdateTs).HasColumnName("update_ts");
            });

            modelBuilder.Entity<EncryptChat>(entity =>
            {
                entity.ToTable("encrypt_chat");

                entity.HasIndex(e => e.Buid, "IX_encrypt_chat_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.LastSeq)
                    .HasColumnName("last_seq")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.LastTimestamp).HasColumnName("last_timestamp");
            });

            modelBuilder.Entity<EncryptDeviceIdentify>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encrypt_device_identify");

                entity.HasIndex(e => new { e.Uid, e.Udid }, "IX_encrypt_device_identify_uid_udid")
                    .IsUnique();

                entity.Property(e => e.DeviceInfo).HasColumnName("device_info");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.EncryptVersion).HasColumnName("encrypt_version");

                entity.Property(e => e.OneTimePreId).HasColumnName("one_time_pre_id");

                entity.Property(e => e.OneTimePreKey).HasColumnName("one_time_pre_key");

                entity.Property(e => e.PublicIdentifyKey).HasColumnName("public_identify_key");

                entity.Property(e => e.PublicSignedPreId).HasColumnName("public_signed_pre_id");

                entity.Property(e => e.PublicSignedPreKey).HasColumnName("public_signed_pre_key");

                entity.Property(e => e.Udid).HasColumnName("udid");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<EncryptSecretKey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("encrypt_secret_key");

                entity.HasIndex(e => e.X3dhKey, "IX_encrypt_secret_key_x3dh_key")
                    .IsUnique();

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.X3dhKey).HasColumnName("x3dh_key");
            });

            modelBuilder.Entity<FavoriteExpression>(entity =>
            {
                entity.ToTable("favorite_expression");

                entity.HasIndex(e => new { e.FavoriteId, e.Type }, "IX_favorite_expression_favorite_id_type")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.FavoriteId).HasColumnName("favorite_id");

                entity.Property(e => e.FavoriteTime).HasColumnName("favorite_time");

                entity.Property(e => e.Object).HasColumnName("object");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<FileAssistant>(entity =>
            {
                entity.ToTable("file_assistant");

                entity.HasIndex(e => e.Buid, "IX_file_assistant_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AliasSl).HasColumnName("_alias_sl");

                entity.Property(e => e.BubbleStatus)
                    .HasColumnName("bubble_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IconStyle).HasColumnName("icon_style");

                entity.Property(e => e.InviteStatus).HasColumnName("invite_status");

                entity.Property(e => e.IsInvisibleFriend)
                    .HasColumnName("is_invisible_friend")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMuted).HasColumnName("is_muted");

                entity.Property(e => e.IsPrivate)
                    .HasColumnName("is_private")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastActiveTimes)
                    .HasColumnType("LONG")
                    .HasColumnName("last_active_times")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NoteName)
                    .HasColumnName("note_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Starred).HasColumnName("starred");

                entity.Property(e => e.TimesContacted)
                    .HasColumnName("times_contacted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<FileTransfer>(entity =>
            {
                entity.ToTable("file_transfer");

                entity.HasIndex(e => e.Taskid, "IX_file_transfer_taskid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buids).HasColumnName("buids");

                entity.Property(e => e.DownType).HasColumnName("down_type");

                entity.Property(e => e.Errorcode).HasColumnName("errorcode");

                entity.Property(e => e.Ext).HasColumnName("ext");

                entity.Property(e => e.ExtData).HasColumnName("ext_data");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.Filepath).HasColumnName("filepath");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Progress).HasColumnName("progress");

                entity.Property(e => e.Sha1sum).HasColumnName("sha1sum");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskPriority).HasColumnName("task_priority");

                entity.Property(e => e.Taskid).HasColumnName("taskid");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UploadType).HasColumnName("upload_type");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.ToTable("friends");

                entity.HasIndex(e => e.Buid, "IX_friends_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AliasSl).HasColumnName("_alias_sl");

                entity.Property(e => e.BubbleStatus)
                    .HasColumnName("bubble_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IconStyle).HasColumnName("icon_style");

                entity.Property(e => e.InviteStatus).HasColumnName("invite_status");

                entity.Property(e => e.IsInvisibleFriend)
                    .HasColumnName("is_invisible_friend")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMuted).HasColumnName("is_muted");

                entity.Property(e => e.IsPrivate)
                    .HasColumnName("is_private")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastActiveTimes)
                    .HasColumnType("LONG")
                    .HasColumnName("last_active_times")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NoteName)
                    .HasColumnName("note_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Score)
                    .HasColumnName("score")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Starred).HasColumnName("starred");

                entity.Property(e => e.TimesContacted)
                    .HasColumnName("times_contacted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<FriendRingback>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("friend_ringback");

                entity.HasIndex(e => e.Buid, "IX_friend_ringback_buid")
                    .IsUnique();

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.ToneId).HasColumnName("tone_id");

                entity.Property(e => e.Uptime).HasColumnName("uptime");
            });

            modelBuilder.Entity<FriendSetting>(entity =>
            {
                entity.ToTable("friend_settings");

                entity.HasIndex(e => e.Buid, "IX_friend_settings_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.CallMuted)
                    .HasColumnName("call_muted")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChatBackground).HasColumnName("chat_background");

                entity.Property(e => e.ChatColor)
                    .HasColumnName("chat_color")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ChatColor2).HasColumnName("chat_color2");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.StoryMuted)
                    .HasColumnName("story_muted")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<HdVideo>(entity =>
            {
                entity.ToTable("hd_video");

                entity.HasIndex(e => e.Buid, "IX_hd_video_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.IsHdVideo).HasColumnName("is_hd_video");

                entity.Property(e => e.IsHdVideoCapable).HasColumnName("is_hd_video_capable");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<HdVideo2>(entity =>
            {
                entity.ToTable("hd_video2");

                entity.HasIndex(e => e.Buid, "IX_hd_video2_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.IsHdVideo).HasColumnName("is_hd_video");

                entity.Property(e => e.IsHdVideoCapable).HasColumnName("is_hd_video_capable");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<ImoLive>(entity =>
            {
                entity.ToTable("imo_live");

                entity.HasIndex(e => e.Id, "IX_imo_live__id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnType("LONG")
                    .HasColumnName("lastUpdateTime");

                entity.Property(e => e.RoomId)
                    .HasColumnType("LONG")
                    .HasColumnName("roomId");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ImoPhonebook>(entity =>
            {
                entity.ToTable("imo_phonebook");

                entity.HasIndex(e => e.Uid, "imo_phonebook_uid");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Card).HasColumnName("card");

                entity.Property(e => e.IncomingCalls).HasColumnName("incoming_calls");

                entity.Property(e => e.IncomingSms).HasColumnName("incoming_sms");

                entity.Property(e => e.InviteStatus).HasColumnName("invite_status");

                entity.Property(e => e.LastContacted).HasColumnName("last_contacted");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NewScore).HasColumnName("new_score");

                entity.Property(e => e.Normalized).HasColumnName("normalized");

                entity.Property(e => e.NumDaysCalls).HasColumnName("num_days_calls");

                entity.Property(e => e.NumDaysSms).HasColumnName("num_days_sms");

                entity.Property(e => e.OutgoingCalls).HasColumnName("outgoing_calls");

                entity.Property(e => e.OutgoingSms).HasColumnName("outgoing_sms");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.Starred).HasColumnName("starred");

                entity.Property(e => e.TimeIncoming).HasColumnName("time_incoming");

                entity.Property(e => e.TimeOutgoing).HasColumnName("time_outgoing");

                entity.Property(e => e.TimesContacted).HasColumnName("times_contacted");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<LocalRecommendPhonebookContact>(entity =>
            {
                entity.ToTable("local_recommend_phonebook_contact");

                entity.HasIndex(e => new { e.AnonId, e.Timestamp }, "IX_local_recommend_phonebook_contact_anon_id_timestamp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.PhonebookName).HasColumnName("phonebook_name");

                entity.Property(e => e.RelId).HasColumnName("rel_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("messages");

                entity.HasIndex(e => new { e.Buid, e.Timestamp }, "IX_messages_buid_timestamp")
                    .IsUnique();

                entity.HasIndex(e => e.Buid, "messages_buid");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.AuthorAlias).HasColumnName("author_alias");

                entity.Property(e => e.AuthorIcon).HasColumnName("author_icon");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.ClickNumTries).HasColumnName("click_num_tries");

                entity.Property(e => e.DeleteType).HasColumnName("delete_type");

                entity.Property(e => e.EncryptFlag).HasColumnName("encrypt_flag");

                entity.Property(e => e.ExpirationTimestamp)
                    .HasColumnType("LONG")
                    .HasColumnName("expiration_timestamp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.GroupMsgId).HasColumnName("group_msg_id");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.MessageIndex).HasColumnName("message_index");

                entity.Property(e => e.MessagePlayed)
                    .HasColumnName("message_played")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.MessageTranslationInfo).HasColumnName("message_translation_info");

                entity.Property(e => e.MessageType).HasColumnName("message_type");

                entity.Property(e => e.MsgCheckStatus)
                    .HasColumnName("msg_check_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.MsgNeedFiltered).HasColumnName("msg_need_filtered");

                entity.Property(e => e.NumTries)
                    .HasColumnName("num_tries")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PreTs)
                    .HasColumnType("LONG")
                    .HasColumnName("pre_ts")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SenderTimestampNano)
                    .HasColumnType("LONG")
                    .HasColumnName("sender_timestamp_nano")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SeqNumber)
                    .HasColumnType("LONG")
                    .HasColumnName("seq_number")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.TsOpenTimeMachine)
                    .HasColumnType("LONG")
                    .HasColumnName("ts_open_time_machine")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            modelBuilder.Entity<MyFile>(entity =>
            {
                entity.ToTable("my_files");

                entity.HasIndex(e => e.UniqueId, "IX_my_files_unique_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.ImRowId)
                    .HasColumnName("im_row_id")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.IsLocal).HasColumnName("is_local");

                entity.Property(e => e.IsSent).HasColumnName("is_sent");

                entity.Property(e => e.MessageTs)
                    .HasColumnType("INTERGER")
                    .HasColumnName("message_ts");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.Property(e => e.State)
                    .HasColumnType("INTERGER")
                    .HasColumnName("state");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.UniqueId).HasColumnName("unique_id");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<NearbyLog>(entity =>
            {
                entity.ToTable("nearby_log");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.Filesize).HasColumnName("filesize");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Payloadid).HasColumnName("payloadid");

                entity.Property(e => e.Thumb).HasColumnName("thumb");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<NewContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("new_contact");

                entity.HasIndex(e => new { e.Buid, e.Timestamp }, "IX_new_contact_buid_timestamp")
                    .IsUnique();

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.ToTable("phone_numbers");

                entity.HasIndex(e => new { e.Uid, e.Phone }, "IX_phone_numbers_uid_phone")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "phone_numbers_phone");

                entity.HasIndex(e => e.Uid, "phone_numbers_uid");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<PhonebookEntry>(entity =>
            {
                entity.ToTable("phonebook_entries");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Card).HasColumnName("card");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.DataVersion)
                    .HasColumnName("data_version")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NormalizedPhone).HasColumnName("normalized_phone");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<PixelBackup>(entity =>
            {
                entity.ToTable("pixel_backup");

                entity.HasIndex(e => new { e.Buid, e.ObjectId }, "IX_pixel_backup_buid_object_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("post");

                entity.HasIndex(e => new { e.ChannelId, e.PostId, e.Timestamp }, "IX_post_channel_id_post_id_timestamp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.ChannelId).HasColumnName("channel_id");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.Display).HasColumnName("display");

                entity.Property(e => e.Fake)
                    .HasColumnName("fake")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.IsAck)
                    .HasColumnName("is_ack")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPlayed)
                    .HasColumnName("is_played")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogInfo).HasColumnName("log_info");

                entity.Property(e => e.MessageType)
                    .HasColumnName("message_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NewState)
                    .HasColumnName("new_state")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostInfo).HasColumnName("post_info");

                entity.Property(e => e.PostType).HasColumnName("post_type");

                entity.Property(e => e.SendState)
                    .HasColumnName("send_state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("INTERGER")
                    .HasColumnName("timestamp");

                entity.Property(e => e.TimestampNano)
                    .HasColumnType("INTERGER")
                    .HasColumnName("timestamp_nano");
            });

            modelBuilder.Entity<PrivacyEncryptDevice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("privacy_encrypt_device");

                entity.HasIndex(e => new { e.Uid, e.Udid }, "IX_privacy_encrypt_device_uid_udid")
                    .IsUnique();

                entity.Property(e => e.DeviceInfo).HasColumnName("device_info");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.EncryptVersion).HasColumnName("encrypt_version");

                entity.Property(e => e.OfflineTs).HasColumnName("offline_ts");

                entity.Property(e => e.OneTimePreId).HasColumnName("one_time_pre_id");

                entity.Property(e => e.OneTimePreKey).HasColumnName("one_time_pre_key");

                entity.Property(e => e.PublicIdentifyKey).HasColumnName("public_identify_key");

                entity.Property(e => e.PublicSignedPreId).HasColumnName("public_signed_pre_id");

                entity.Property(e => e.PublicSignedPreKey).HasColumnName("public_signed_pre_key");

                entity.Property(e => e.Udid).HasColumnName("udid");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<RecommendPhonebookContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("recommend_phonebook_contact");

                entity.HasIndex(e => new { e.AnonId, e.Timestamp }, "IX_recommend_phonebook_contact_anon_id_timestamp")
                    .IsUnique();

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.PhonebookName).HasColumnName("phonebook_name");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("relationship");

                entity.HasIndex(e => e.RelId, "IX_relationship_rel_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AnonId).HasColumnName("anon_id");

                entity.Property(e => e.HasReply).HasColumnName("has_reply");

                entity.Property(e => e.HasTipLimit).HasColumnName("has_tip_limit");

                entity.Property(e => e.IsIgnore).HasColumnName("is_ignore");

                entity.Property(e => e.RelId).HasColumnName("rel_id");

                entity.Property(e => e.Request).HasColumnName("request");

                entity.Property(e => e.RequestStatus).HasColumnName("request_status");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.SourceType).HasColumnName("source_type");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.TinyProfile).HasColumnName("tiny_profile");
            });

            modelBuilder.Entity<RelationshipMessage>(entity =>
            {
                entity.ToTable("relationship_message");

                entity.HasIndex(e => new { e.RelId, e.MsgSeq, e.Timestamp }, "IX_relationship_message_rel_id_msg_seq_timestamp")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.ImdataType).HasColumnName("imdata_type");

                entity.Property(e => e.IsSilent).HasColumnName("is_silent");

                entity.Property(e => e.LastMessage)
                    .HasColumnType("Text")
                    .HasColumnName("last_message");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.MessageTranslationInfo).HasColumnName("message_translation_info");

                entity.Property(e => e.MessageType).HasColumnName("message_type");

                entity.Property(e => e.MsgSeq).HasColumnName("msg_seq");

                entity.Property(e => e.RelId).HasColumnName("rel_id");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<SecretChat>(entity =>
            {
                entity.ToTable("secret_chat");

                entity.HasIndex(e => e.Buid, "IX_secret_chat_buid")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.DeviceInfo).HasColumnName("device_info");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<SecretKey>(entity =>
            {
                entity.ToTable("secret_keys");

                entity.HasIndex(e => new { e.DeviceId, e.X3dhKey }, "IX_secret_keys_device_id_x3dh_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.X3dhKey).HasColumnName("x3dh_key");
            });

            modelBuilder.Entity<SecretMessage>(entity =>
            {
                entity.ToTable("secret_message");

                entity.HasIndex(e => new { e.Buid, e.Budid, e.MsgId }, "IX_secret_message_buid_budid_msg_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.AttachmentDownloadPath).HasColumnName("attachment_download_path");

                entity.Property(e => e.AttachmentEncryptedPath).HasColumnName("attachment_encrypted_path");

                entity.Property(e => e.Budid).HasColumnName("budid");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.CipherText).HasColumnName("cipher_text");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.ImdataType).HasColumnName("imdata_type");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.MessagePlayed).HasColumnName("message_played");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.MessageType).HasColumnName("message_type");

                entity.Property(e => e.MsgId).HasColumnName("msg_id");

                entity.Property(e => e.MsgSeq).HasColumnName("msg_seq");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SenderTimestampNano).HasColumnName("sender_timestamp_nano");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            });

            modelBuilder.Entity<SecretSeq>(entity =>
            {
                entity.ToTable("secret_seq");

                entity.HasIndex(e => new { e.Buid, e.DeviceId }, "IX_secret_seq_buid_device_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.LastSeq)
                    .HasColumnType("INT")
                    .HasColumnName("last_seq")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Sticker>(entity =>
            {
                entity.ToTable("sticker");

                entity.HasIndex(e => e.StickerId, "IX_sticker_sticker_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.PackId).HasColumnName("pack_id");

                entity.Property(e => e.PackType).HasColumnName("pack_type");

                entity.Property(e => e.StickerId).HasColumnName("sticker_id");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<StickersPack>(entity =>
            {
                entity.ToTable("stickers_pack");

                entity.HasIndex(e => e.PackId, "IX_stickers_pack_pack_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DownloadTime)
                    .HasColumnName("download_time")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InUse)
                    .HasColumnName("in_use")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPromote)
                    .HasColumnName("is_promote")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NumStickers).HasColumnName("num_stickers");

                entity.Property(e => e.PackId).HasColumnName("pack_id");

                entity.Property(e => e.PackType).HasColumnName("pack_type");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Purchased)
                    .HasColumnName("purchased")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Scene).HasColumnName("scene");

                entity.Property(e => e.TabImg).HasColumnName("tab_img");

                entity.Property(e => e.TitleImg).HasColumnName("title_img");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.ToTable("stories");

                entity.HasIndex(e => new { e.Buid, e.ObjectId }, "IX_stories_buid_object_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.GroupNum)
                    .HasColumnName("group_num")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.IsPublic).HasColumnName("is_public");

                entity.Property(e => e.MessageLiked).HasColumnName("message_liked");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.NumTries)
                    .HasColumnName("num_tries")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.OriginalId).HasColumnName("original_id");

                entity.Property(e => e.RecommendInfo).HasColumnName("recommend_info");

                entity.Property(e => e.StoryAlbumList).HasColumnName("story_album_list");

                entity.Property(e => e.StoryFriendsLiked).HasColumnName("story_friends_liked");

                entity.Property(e => e.StoryIntimacyScore)
                    .HasColumnName("story_intimacy_score")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StoryPushNotify)
                    .HasColumnName("story_push_notify")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            modelBuilder.Entity<StorySendDraft>(entity =>
            {
                entity.ToTable("story_send_draft");

                entity.HasIndex(e => e.DraftId, "IX_story_send_draft_draft_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.DraftId).HasColumnName("draft_id");

                entity.Property(e => e.GroupGid).HasColumnName("group_gid");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.IsForFeed).HasColumnName("is_for_feed");

                entity.Property(e => e.IsFront).HasColumnName("is_front");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.OverlayPath).HasColumnName("overlay_path");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.SendStory).HasColumnName("send_story");

                entity.Property(e => e.Source).HasColumnName("source");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StoryConfig).HasColumnName("story_config");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            modelBuilder.Entity<TrackedInvite>(entity =>
            {
                entity.ToTable("tracked_invites");

                entity.HasIndex(e => e.Phone, "IX_tracked_invites_phone")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Time).HasColumnName("time");
            });

            modelBuilder.Entity<UserChannel>(entity =>
            {
                entity.ToTable("user_channel");

                entity.HasIndex(e => e.UserChannelId, "IX_user_channel_user_channel_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.Bio).HasColumnName("bio");

                entity.Property(e => e.CertificationId).HasColumnName("certification_id");

                entity.Property(e => e.ChannelStatus).HasColumnName("channel_status");

                entity.Property(e => e.ChannelType).HasColumnName("channel_type");

                entity.Property(e => e.ChannelUserExtend).HasColumnName("channel_user_extend");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FollowTimestamp).HasColumnName("follow_timestamp");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.InputHint).HasColumnName("input_hint");

                entity.Property(e => e.IsAutoCollapsible).HasColumnName("is_auto_collapsible");

                entity.Property(e => e.IsCollapsible).HasColumnName("is_collapsible");

                entity.Property(e => e.IsDefaultBackground).HasColumnName("is_default_background");

                entity.Property(e => e.IsFollowing).HasColumnName("is_following");

                entity.Property(e => e.IsMuted).HasColumnName("is_muted");

                entity.Property(e => e.IsOwner).HasColumnName("is_owner");

                entity.Property(e => e.IsShield).HasColumnName("is_shield");

                entity.Property(e => e.LastReadTimestamp).HasColumnName("last_read_timestamp");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PostLastTime)
                    .HasColumnName("post_last_time")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostMaxSeq).HasColumnName("post_max_seq");

                entity.Property(e => e.ShareId).HasColumnName("share_id");

                entity.Property(e => e.UnreadBroadcastNum).HasColumnName("unread_broadcast_num");

                entity.Property(e => e.UnreadChatNum).HasColumnName("unread_chat_num");

                entity.Property(e => e.UnreadNum).HasColumnName("unread_num");

                entity.Property(e => e.UserChannelId).HasColumnName("user_channel_id");

                entity.Property(e => e.Welcome).HasColumnName("welcome");
            });

            modelBuilder.Entity<UserChannelPost>(entity =>
            {
                entity.ToTable("user_channel_post");

                entity.HasIndex(e => e.PostId, "IX_user_channel_post_post_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.ChannelMessageType).HasColumnName("channel_message_type");

                entity.Property(e => e.IsAck).HasColumnName("is_ack");

                entity.Property(e => e.IsMock).HasColumnName("is_mock");

                entity.Property(e => e.IsReadTransTextToAudio)
                    .HasColumnName("is_read_trans_text_to_audio")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogInfo).HasColumnName("log_info");

                entity.Property(e => e.MessageType)
                    .HasColumnName("message_type")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Msg).HasColumnName("msg");

                entity.Property(e => e.MsgSeq)
                    .HasColumnName("msg_seq")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageType).HasColumnName("page_type");

                entity.Property(e => e.PostExtend).HasColumnName("post_extend");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostInfo).HasColumnName("post_info");

                entity.Property(e => e.PostStatus)
                    .HasColumnName("post_status")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PostSubType).HasColumnName("post_sub_type");

                entity.Property(e => e.PostType).HasColumnName("post_type");

                entity.Property(e => e.SendCommandId).HasColumnName("send_command_id");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransAudioToText).HasColumnName("trans_audio_to_text");

                entity.Property(e => e.TransInfo).HasColumnName("trans_info");

                entity.Property(e => e.TransTextToAudio).HasColumnName("trans_text_to_audio");

                entity.Property(e => e.UserChannelId).HasColumnName("user_channel_id");
            });

            modelBuilder.Entity<VideoMessage>(entity =>
            {
                entity.ToTable("video_messages");

                entity.HasIndex(e => e.Timestamp, "IX_video_messages_timestamp")
                    .IsUnique();

                entity.HasIndex(e => e.Buid, "video_messages_buid");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Alias).HasColumnName("alias");

                entity.Property(e => e.Author).HasColumnName("author");

                entity.Property(e => e.AuthorAlias).HasColumnName("author_alias");

                entity.Property(e => e.AuthorIcon).HasColumnName("author_icon");

                entity.Property(e => e.Buid).HasColumnName("buid");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Imdata).HasColumnName("imdata");

                entity.Property(e => e.LastMessage).HasColumnName("last_message");

                entity.Property(e => e.MessageIndex).HasColumnName("message_index");

                entity.Property(e => e.MessageRead).HasColumnName("message_read");

                entity.Property(e => e.MessageState).HasColumnName("message_state");

                entity.Property(e => e.MessageType).HasColumnName("message_type");

                entity.Property(e => e.Timestamp).HasColumnName("timestamp");

                entity.Property(e => e.ViewType).HasColumnName("view_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
