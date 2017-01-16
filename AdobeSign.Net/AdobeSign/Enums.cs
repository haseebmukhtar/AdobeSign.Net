using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeSignNet.AdobeSign
{
    class Enums
    {
    }

    //Enums to be used


    public enum Result
    {

        /// <remarks/>
        REMINDER_SENT,

        /// <remarks/>
        CANCELLED,

        /// <remarks/>
        ALREADY_SIGNED,

        /// <remarks/>
        ALREADY_CANCELLED,

        /// <remarks/>
        INVALID_DOCUMENT_KEY,

        /// <remarks/>
        INVALID_API_KEY,
    }

    public enum UserVerificationStatus
    {

        /// <remarks/>
        VALID,

        /// <remarks/>
        DOES_NOT_EXIST,

        /// <remarks/>
        INVALID_PASSWORD,

        /// <remarks/>
        UNVERIFIED,
    }

    public enum AuthenticationMethod
    {

        /// <remarks/>
        NONE,

        /// <remarks/>
        INHERITED_FROM_DOCUMENT,

        /// <remarks/>
        PASSWORD,

        /// <remarks/>
        WEB_IDENTITY,

        /// <remarks/>
        KBA,

        /// <remarks/>
        PHONE,
    }


    public enum ReminderFrequency
    {

        /// <remarks/>
        DAILY_UNTIL_SIGNED,

        /// <remarks/>
        WEEKLY_UNTIL_SIGNED,

        /// <remarks/>
        NEVER,
    }


    public enum AppliesTo
    {

        /// <remarks/>
        NONE,

        /// <remarks/>
        EXTERNAL_USERS,

        /// <remarks/>
        INTERNAL_USERS,

        /// <remarks/>
        ALL_USERS,
    }


    public enum SignatureFlow
    {

        /// <remarks/>
        SENDER_SIGNS_LAST,

        /// <remarks/>
        SENDER_SIGNS_FIRST,

        /// <remarks/>
        SENDER_SIGNATURE_NOT_REQUIRED,

        /// <remarks/>
        SENDER_SIGNS_ONLY,

        /// <remarks/>
        SEQUENTIAL,

        /// <remarks/>
        PARALLEL,
    }


    public enum AccountType
    {

        /// <remarks/>
        FREE,

        /// <remarks/>
        PRO,

        /// <remarks/>
        TEAM,

        /// <remarks/>
        TEAM_TRIAL,

        /// <remarks/>
        ENTERPRISE,

        /// <remarks/>
        ENTERPRISE_TRIAL,

        /// <remarks/>
        GLOBAL,

        /// <remarks/>
        GLOBAL_TRIAL,
    }


    public enum UserCapabilityFlag
    {

        /// <remarks/>
        CAN_SEND,

        /// <remarks/>
        CAN_SIGN,

        /// <remarks/>
        CAN_REPLACE_SIGNER,

        /// <remarks/>
        VAULT_ENABLED,

        /// <remarks/>
        VAULT_PER_AGREEMENT,

        /// <remarks/>
        OTHER,
    }


    public enum UserRole
    {

        /// <remarks/>
        API,

        /// <remarks/>
        GROUP_ADMIN,

        /// <remarks/>
        ACCOUNT_ADMIN,

        /// <remarks/>
        OTHER,
    }


    public enum SupportingDocumentContentFormat
    {

        /// <remarks/>
        NONE,

        /// <remarks/>
        ORIGINAL,

        /// <remarks/>
        CONVERTED_PDF,
    }

    public enum Operator
    {

        /// <remarks/>
        EQUALS,

        /// <remarks/>
        NOT_EQUALS,

        /// <remarks/>
        LESS_THAN,

        /// <remarks/>
        LESS_THAN_EQUALS,

        /// <remarks/>
        GREATER_THAN,

        /// <remarks/>
        GREATER_THAN_EQUALS,

        /// <remarks/>
        IN,

        /// <remarks/>
        NOT_IN,

        /// <remarks/>
        CONTAINS,

        /// <remarks/>
        NOT_CONTAINS,
    }


    public enum TextAlignment
    {

        /// <remarks/>
        LEFT,

        /// <remarks/>
        RIGHT,

        /// <remarks/>
        CENTER,
    }


    public enum BorderStyle
    {

        /// <remarks/>
        SOLID,

        /// <remarks/>
        DASHED,

        /// <remarks/>
        BEVELED,

        /// <remarks/>
        INSET,

        /// <remarks/>
        UNDERLINE,
    }


    public enum ContentType
    {

        /// <remarks/>
        DATA,

        /// <remarks/>
        SIGNATURE_BLOCK,

        /// <remarks/>
        SIGNATURE,

        /// <remarks/>
        SIGNER_NAME,

        /// <remarks/>
        SIGNER_FIRST_NAME,

        /// <remarks/>
        SIGNER_LAST_NAME,

        /// <remarks/>
        SIGNER_INITIALS,

        /// <remarks/>
        SIGNER_EMAIL,

        /// <remarks/>
        SIGNER_TITLE,

        /// <remarks/>
        SIGNER_COMPANY,

        /// <remarks/>
        SIGNATURE_DATE,

        /// <remarks/>
        AGREEMENT_NAME,

        /// <remarks/>
        AGREEMENT_MESSAGE,

        /// <remarks/>
        TRANSACTION_ID,

        /// <remarks/>
        SIGNATURE_STAMP,

        /// <remarks/>
        CALC,
    }

    public enum DisplayFormatType
    {

        /// <remarks/>
        DEFAULT,

        /// <remarks/>
        DATE,

        /// <remarks/>
        NUMBER,
    }


    public enum InputType
    {

        /// <remarks/>
        TEXT_FIELD,

        /// <remarks/>
        MULTILINE,

        /// <remarks/>
        PASSWORD,

        /// <remarks/>
        RADIO,

        /// <remarks/>
        CHECKBOX,

        /// <remarks/>
        DROP_DOWN,

        /// <remarks/>
        LISTBOX,

        /// <remarks/>
        SIGNATURE,

        /// <remarks/>
        PDF_SIGNATURE,

        /// <remarks/>
        BUTTON,

        /// <remarks/>
        BLOCK,

        /// <remarks/>
        FILE_CHOOSER,

        /// <remarks/>
        COMB,

        /// <remarks/>
        UNSUPPORTED,
    }


    public enum RadioCheckType
    {

        /// <remarks/>
        CIRCLE,

        /// <remarks/>
        CHECK,

        /// <remarks/>
        CROSS,

        /// <remarks/>
        DIAMOND,

        /// <remarks/>
        SQUARE,

        /// <remarks/>
        STAR,
    }

    public enum ShowHide
    {

        /// <remarks/>
        SHOW,

        /// <remarks/>
        HIDE,

        /// <remarks/>
        DISABLE,

        /// <remarks/>
        ENABLE,
    }


    public enum ReusableDocumentStatus
    {

        /// <remarks/>
        ENABLED,

        /// <remarks/>
        DISABLED,

        /// <remarks/>
        OTHER,
    }

    public enum DocumentListItemUserDocumentStatus
    {

        /// <remarks/>
        WAITING_FOR_MY_SIGNATURE,

        /// <remarks/>
        WAITING_FOR_MY_APPROVAL,

        /// <remarks/>
        OUT_FOR_SIGNATURE,

        /// <remarks/>
        OUT_FOR_APPROVAL,

        /// <remarks/>
        SIGNED,

        /// <remarks/>
        APPROVED,

        /// <remarks/>
        RECALLED,

        /// <remarks/>
        WAITING_FOR_FAXIN,

        /// <remarks/>
        ARCHIVED,

        /// <remarks/>
        FORM,

        /// <remarks/>
        EXPIRED,

        /// <remarks/>
        WIDGET,

        /// <remarks/>
        WAITING_FOR_AUTHORING,

        /// <remarks/>
        SIGNED_IN_ADOBE_ACROBAT,

        /// <remarks/>
        SIGNED_IN_ADOBE_READER,

        /// <remarks/>
        OTHER,
    }


    public enum LibraryTemplateType
    {

        /// <remarks/>
        DOCUMENT,

        /// <remarks/>
        FORM_FIELD_LAYER,
    }


    public enum DocumentLibraryItemScope
    {

        /// <remarks/>
        PERSONAL,

        /// <remarks/>
        SHARED,

        /// <remarks/>
        GLOBAL,
    }

    public enum EmbeddedViewTarget
    {

        /// <remarks/>
        AGREEMENT,

        /// <remarks/>
        AGREEMENT_LIST,

        /// <remarks/>
        USER_PROFILE,

        /// <remarks/>
        ACCOUNT_SETTINGS,
    }


    public enum AgreementEventType
    {

        /// <remarks/>
        CREATED,

        /// <remarks/>
        UPLOADED_BY_SENDER,

        /// <remarks/>
        FAXED_BY_SENDER,

        /// <remarks/>
        PRESIGNED,

        /// <remarks/>
        SIGNED,

        /// <remarks/>
        ESIGNED,

        /// <remarks/>
        DIGSIGNED,

        /// <remarks/>
        APPROVED,

        /// <remarks/>
        OFFLINE_SYNC,

        /// <remarks/>
        FAXIN_RECEIVED,

        /// <remarks/>
        SIGNATURE_REQUESTED,

        /// <remarks/>
        APPROVAL_REQUESTED,

        /// <remarks/>
        RECALLED,

        /// <remarks/>
        REJECTED,

        /// <remarks/>
        EXPIRED,

        /// <remarks/>
        EXPIRED_AUTOMATICALLY,

        /// <remarks/>
        SHARED,

        /// <remarks/>
        EMAIL_VIEWED,

        /// <remarks/>
        AUTO_CANCELLED_CONVERSION_PROBLEM,

        /// <remarks/>
        SIGNER_SUGGESTED_CHANGES,

        /// <remarks/>
        SENDER_CREATED_NEW_REVISION,

        /// <remarks/>
        PASSWORD_AUTHENTICATION_FAILED,

        /// <remarks/>
        KBA_AUTHENTICATION_FAILED,

        /// <remarks/>
        KBA_AUTHENTICATED,

        /// <remarks/>
        WEB_IDENTITY_AUTHENTICATED,

        /// <remarks/>
        WEB_IDENTITY_SPECIFIED,

        /// <remarks/>
        EMAIL_BOUNCED,

        /// <remarks/>
        WIDGET_ENABLED,

        /// <remarks/>
        WIDGET_DISABLED,

        /// <remarks/>
        DELEGATED,

        /// <remarks/>
        AUTO_DELEGATED,

        /// <remarks/>
        REPLACED_SIGNER,

        /// <remarks/>
        VAULTED,

        /// <remarks/>
        DOCUMENTS_DELETED,

        /// <remarks/>
        OTHER,
    }


    public enum ParticipantRole
    {

        /// <remarks/>
        SENDER,

        /// <remarks/>
        SIGNER,

        /// <remarks/>
        APPROVER,

        /// <remarks/>
        CC,

        /// <remarks/>
        DELEGATE,

        /// <remarks/>
        SHARE,

        /// <remarks/>
        WIDGET_SIGNER,

        /// <remarks/>
        OTHER,
    }


    public enum ParticipantSecurityOption
    {

        /// <remarks/>
        PASSWORD,

        /// <remarks/>
        WEB_IDENTITY,

        /// <remarks/>
        KBA,

        /// <remarks/>
        PHONE,

        /// <remarks/>
        OTHER,
    }


    public enum UserAgreementStatus
    {

        /// <remarks/>
        WAITING_FOR_MY_SIGNATURE,

        /// <remarks/>
        WAITING_FOR_MY_APPROVAL,

        /// <remarks/>
        OUT_FOR_SIGNATURE,

        /// <remarks/>
        SIGNED,

        /// <remarks/>
        APPROVED,

        /// <remarks/>
        RECALLED,

        /// <remarks/>
        HIDDEN,

        /// <remarks/>
        NOT_YET_VISIBLE,

        /// <remarks/>
        WAITING_FOR_FAXIN,

        /// <remarks/>
        ARCHIVED,

        /// <remarks/>
        UNKNOWN,

        /// <remarks/>
        PARTIAL,

        /// <remarks/>
        FORM,

        /// <remarks/>
        WAITING_FOR_AUTHORING,

        /// <remarks/>
        OUT_FOR_APPROVAL,

        /// <remarks/>
        WIDGET,

        /// <remarks/>
        EXPIRED,

        /// <remarks/>
        WAITING_FOR_MY_REVIEW,

        /// <remarks/>
        IN_REVIEW,

        /// <remarks/>
        OTHER,

        /// <remarks/>
        SIGNED_IN_ADOBE_ACROBAT,

        /// <remarks/>
        SIGNED_IN_ADOBE_READER,
    }


    public enum AgreementStatus
    {

        /// <remarks/>
        OUT_FOR_SIGNATURE,

        /// <remarks/>
        WAITING_FOR_REVIEW,

        /// <remarks/>
        SIGNED,

        /// <remarks/>
        APPROVED,

        /// <remarks/>
        ABORTED,

        /// <remarks/>
        DOCUMENT_LIBRARY,

        /// <remarks/>
        WIDGET,

        /// <remarks/>
        EXPIRED,

        /// <remarks/>
        ARCHIVED,

        /// <remarks/>
        PREFILL,

        /// <remarks/>
        AUTHORING,

        /// <remarks/>
        WAITING_FOR_FAXIN,

        /// <remarks/>
        WAITING_FOR_VERIFICATION,

        /// <remarks/>
        WIDGET_WAITING_FOR_VERIFICATION,

        /// <remarks/>
        WAITING_FOR_PAYMENT,

        /// <remarks/>
        OUT_FOR_APPROVAL,

        /// <remarks/>
        OTHER,

        /// <remarks/>
        SIGNED_IN_ADOBE_ACROBAT,

        /// <remarks/>
        SIGNED_IN_ADOBE_READER,
    }

   

    public enum ScalingType
    {

        /// <remarks/>
        FIXED_WIDTH,

        /// <remarks/>
        PERCENT_ZOOM,
    }

    public enum IncludeScalingTypes
    {

        /// <remarks/>
        ALL,

        /// <remarks/>
        FIXED_WIDTH,

        /// <remarks/>
        PERCENT_ZOOM,
    }


    public enum ComposeDocumentType
    {

        /// <remarks/>
        SIGN_THEN_DELIVER,

        /// <remarks/>
        DELIVER_ONLY,

        /// <remarks/>
        SIGN_THEN_SEND,

        /// <remarks/>
        SEND_ONLY,
    }


    public enum LibrarySharingMode
    {

        /// <remarks/>
        USER,

        /// <remarks/>
        GROUP,

        /// <remarks/>
        ACCOUNT,
    }

    public enum FormType
    {

        /// <remarks/>
        NORMAL,

        /// <remarks/>
        WIDGET,
    }


    public enum OptIn
    {

        /// <remarks/>
        YES,

        /// <remarks/>
        NO,

        /// <remarks/>
        UNKNOWN,
    }



}
