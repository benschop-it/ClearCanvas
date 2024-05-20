namespace ClearCanvas.Enterprise.Core.Porting
{
    public enum MessageQueueErrorCode
    {
        //
        // Summary:
        //     Message Queuing does not return this error code.
        Base = -1072824320,
        //
        // Summary:
        //     Message text: Generic Error.
        Generic = -1072824319,
        //
        // Summary:
        //     Message text: One or more of the passed properties are invalid.
        Property = -1072824318,
        //
        // Summary:
        //     Message text: The queue is not registered in the directory service.
        QueueNotFound = -1072824317,
        //
        // Summary:
        //     Message text: A queue with the same pathname is already registered.
        QueueExists = -1072824315,
        //
        // Summary:
        //     Message text: An invalid parameter passed to a function.
        InvalidParameter = -1072824314,
        //
        // Summary:
        //     Message text: An invalid handle passed to a function.
        InvalidHandle = -1072824313,
        //
        // Summary:
        //     Message text: The operation was canceled before it could be completed.
        OperationCanceled = -1072824312,
        //
        // Summary:
        //     Message text: Sharing violation. The queue is already opened for exclusive receive.
        SharingViolation = -1072824311,
        //
        // Summary:
        //     Message text: The Message Queues service is not available.
        ServiceNotAvailable = -1072824309,
        //
        // Summary:
        //     Message text: The specified computer could not be found.
        MachineNotFound = -1072824307,
        //
        // Summary:
        //     Message text: Illegal sort specified (for example, duplicate columns).
        IllegalSort = -1072824304,
        //
        // Summary:
        //     Message text: The user has an invalid user name.
        IllegalUser = -1072824303,
        //
        // Summary:
        //     Message text: No connection with this site's controller(s).
        NoDs = -1072824301,
        //
        // Summary:
        //     Message text: Invalid queue path name.
        IllegalQueuePathName = -1072824300,
        //
        // Summary:
        //     Message text: Invalid property value.
        IllegalPropertyValue = -1072824296,
        //
        // Summary:
        //     Message text: Invalid VARTYPE value.
        IllegalPropertyVt = -1072824295,
        //
        // Summary:
        //     Message text: The buffer supplied to MQReceiveMessage for message body retrieval
        //     was too small. The message is not removed from the queue and part of the message
        //     body that fits in the buffer was copied.
        BufferOverflow = -1072824294,
        //
        // Summary:
        //     Message text: The receive or peek message time-out has expired.
        IOTimeout = -1072824293,
        //
        // Summary:
        //     Message text: MQ_ACTION_PEEK_NEXT specified to MQReceiveMessage can not be used
        //     with the current cursor position.
        IllegalCursorAction = -1072824292,
        //
        // Summary:
        //     Message text: A message that is currently pointed at by the cursor has been removed
        //     from the queue by another process or by another call to receive the message without
        //     the use of this cursor.
        MessageAlreadyReceived = -1072824291,
        //
        // Summary:
        //     Message text: The given format name is invalid.
        IllegalFormatName = -1072824290,
        //
        // Summary:
        //     Message text: The format name buffer supplied to the API was too small to fit
        //     the format name.
        FormatNameBufferTooSmall = -1072824289,
        //
        // Summary:
        //     Message text: The requested operation for the specified format name is not supported.
        UnsupportedFormatNameOperation = -1072824288,
        //
        // Summary:
        //     Message text: The specified security descriptor is not a valid security descriptor.
        IllegalSecurityDescriptor = -1072824287,
        //
        // Summary:
        //     Message text: The passed buffer for the user identifier property is too small.
        SenderIdBufferTooSmall = -1072824286,
        //
        // Summary:
        //     Message text: The size of the buffer passed to MQGetQueueSecurity is too small.
        SecurityDescriptorBufferTooSmall = -1072824285,
        //
        // Summary:
        //     Message text: The RPC server cannot impersonate the client application, hence
        //     security credentials could not be verified.
        CannotImpersonateClient = -1072824284,
        //
        // Summary:
        //     Message text: Access is denied.
        AccessDenied = -1072824283,
        //
        // Summary:
        //     Message text: Client does not have the required privileges to perform the operation.
        PrivilegeNotHeld = -1072824282,
        //
        // Summary:
        //     Message text: Insufficient resources to perform operation.
        InsufficientResources = -1072824281,
        //
        // Summary:
        //     Message text: Request failed because user buffer is too small to hold the returned
        //     information.
        UserBufferTooSmall = -1072824280,
        //
        // Summary:
        //     Message text: Could not store a recoverable or journal message. Message was not
        //     sent.
        MessageStorageFailed = -1072824278,
        //
        // Summary:
        //     Message text: The passed buffer for the user certificate property is too small.
        SenderCertificateBufferTooSmall = -1072824277,
        //
        // Summary:
        //     Message text: The user certificate is not valid.
        InvalidCertificate = -1072824276,
        //
        // Summary:
        //     Message text: The internal Message Queuing certificate is corrupted.
        CorruptedInternalCertificate = -1072824275,
        //
        // Summary:
        //     Message text: The internal Message Queuing certificate for the user does not
        //     exist.
        NoInternalUserCertificate = -1072824273,
        //
        // Summary:
        //     Message text: A cryptographic function has failed.
        CorruptedSecurityData = -1072824272,
        //
        // Summary:
        //     Message text: The personal certificate store is corrupted.
        CorruptedPersonalCertStore = -1072824271,
        //
        // Summary:
        //     Message text: The computer does not support encryption operations.
        ComputerDoesNotSupportEncryption = -1072824269,
        //
        // Summary:
        //     Message text: Bad security context.
        BadSecurityContext = -1072824267,
        //
        // Summary:
        //     Message text: Could not get the SID information out of the thread token.
        CouldNotGetUserSid = -1072824266,
        //
        // Summary:
        //     Message text: Could not get the account information for the user.
        CouldNotGetAccountInfo = -1072824265,
        //
        // Summary:
        //     Message text: Invalid MQCOLUMNS parameter.
        IllegalCriteriaColumns = -1072824264,
        //
        // Summary:
        //     Message text: Invalid property identifier value.
        IllegalPropertyId = -1072824263,
        //
        // Summary:
        //     Message text: Invalid relation value in restriction.
        IllegalRelation = -1072824262,
        //
        // Summary:
        //     Message text: Illegal property buffer size.
        IllegalPropertySize = -1072824261,
        //
        // Summary:
        //     Message text: Invalid propid value in MQRESTRICTION parameter.
        IllegalRestrictionPropertyId = -1072824260,
        //
        // Summary:
        //     Message text: Illegal MQQUEUEPROPS parameter, either null or with zero properties.
        IllegalQueueProperties = -1072824259,
        //
        // Summary:
        //     Message text: Invalid property for the requested operation
        PropertyNotAllowed = -1072824258,
        //
        // Summary:
        //     Message text: Not all the required properties for the operation were specified
        //     in the input parameters.
        InsufficientProperties = -1072824257,
        //
        // Summary:
        //     Message text: Computer with the same name already exists in the site.
        MachineExists = -1072824256,
        //
        // Summary:
        //     Message text: Illegal MQQMPROPS parameter, either null or with zero properties.
        IllegalMessageProperties = -1072824255,
        //
        // Summary:
        //     Message text: Directory service is full.
        DsIsFull = -1072824254,
        //
        // Summary:
        //     Message text: Internal directory service error.
        DsError = -1072824253,
        //
        // Summary:
        //     Message text: Invalid object owner. For example CreateQueue failed because the
        //     Queue Manager object is invalid.
        InvalidOwner = -1072824252,
        //
        // Summary:
        //     Message text: The specified access mode is not supported.
        UnsupportedAccessMode = -1072824251,
        //
        // Summary:
        //     Message text: The supplied result buffer is too small.
        ResultBufferTooSmall = -1072824250,
        //
        // Summary:
        //     Message text: The connected network cannot be deleted; it is in use.
        DeleteConnectedNetworkInUse = -1072824248,
        //
        // Summary:
        //     Message text: No response from object owner.
        NoResponseFromObjectServer = -1072824247,
        //
        // Summary:
        //     Message text: Object owner is not reachable.
        ObjectServerNotAvailable = -1072824246,
        //
        // Summary:
        //     Message text: Error while reading from a queue residing on a remote computer.
        QueueNotAvailable = -1072824245,
        //
        // Summary:
        //     Message text: Cannot connect to MS DTC.
        DtcConnect = -1072824244,
        //
        // Summary:
        //     Message text: Cannot import the transaction.
        TransactionImport = -1072824242,
        //
        // Summary:
        //     Message text: Wrong transaction usage.
        TransactionUsage = -1072824240,
        //
        // Summary:
        //     Message text: Wrong transaction operations sequence.
        TransactionSequence = -1072824239,
        //
        // Summary:
        //     Message text: Connector Type is mandatory when sending an Acknowledgment or secure
        //     message.
        MissingConnectorType = -1072824235,
        //
        // Summary:
        //     Message text: The Queue Manager service has been restarted. The queue handle
        //     is stale and should be closed.
        StaleHandle = -1072824234,
        //
        // Summary:
        //     Message text: Cannot enlist the transaction.
        TransactionEnlist = -1072824232,
        //
        // Summary:
        //     Message text: The queue was deleted. Messages cannot be received anymore using
        //     this queue instance. The queue should be closed.
        QueueDeleted = -1072824230,
        //
        // Summary:
        //     Message text: Invalid context parameter.
        IllegalContext = -1072824229,
        //
        // Summary:
        //     Message text: Invalid propid value in MQSORTSET.
        IllegalSortPropertyId = -1072824228,
        //
        // Summary:
        //     Message text: The label buffer supplied to the API was too small.
        LabelBufferTooSmall = -1072824226,
        //
        // Summary:
        //     Message text: The list of MQIS servers (in registry) is empty.
        MqisServerEmpty = -1072824225,
        //
        // Summary:
        //     Message text: MQIS database is in read-only mode.
        MqisReadOnlyMode = -1072824224,
        //
        // Summary:
        //     Message text: The passed buffer for the Symmetric key property is too small.
        SymmetricKeyBufferTooSmall = -1072824223,
        //
        // Summary:
        //     Message text: The passed buffer for the Signature property is too small.
        SignatureBufferTooSmall = -1072824222,
        //
        // Summary:
        //     Message text: The passed buffer for the Provider name property is too small.
        ProviderNameBufferTooSmall = -1072824221,
        //
        // Summary:
        //     Message text: The operation is invalid on foreign message queuing systems.
        IllegalOperation = -1072824220,
        //
        // Summary:
        //     Message text: Another MQIS server is being installed; write operations to the
        //     database are not allowed at this time.
        WriteNotAllowed = -1072824219,
        //
        // Summary:
        //     Message text: Message Queuing-independent clients cannot serve Message Queuing-dependent
        //     clients.
        WksCantServeClient = -1072824218,
        //
        // Summary:
        //     Message text: The number of dependent clients served by this Message Queuing
        //     server reached its upper limit.
        DependentClientLicenseOverflow = -1072824217,
        //
        // Summary:
        //     Message text: The.ini file for the queue in LQS was deleted because it was corrupted.
        CorruptedQueueWasDeleted = -1072824216,
        //
        // Summary:
        //     Message text: The remote machine is not available.
        RemoteMachineNotAvailable = -1072824215,
        //
        // Summary:
        //     Message text: The operation is not supported for a WORKGROUP installation computer.
        UnsupportedOperation = -1072824214,
        //
        // Summary:
        //     Message text: The Cryptographic Service Provider is not supported by Message
        //     Queuing.
        EncryptionProviderNotSupported = -1072824213,
        //
        // Summary:
        //     Message text: Unable to set the security descriptor for the cryptographic keys.
        CannotSetCryptographicSecurityDescriptor = -1072824212,
        //
        // Summary:
        //     Message text: A user attempted to send an authenticated message without a certificate.
        CertificateNotProvided = -1072824211,
        //
        // Summary:
        //     DNS property is not supported as criteria to locate queues.
        QDnsPropertyNotSupported = -1072824210,
        //
        // Summary:
        //     Message text: Unable to create a certificate store for the internal certificate.
        CannotCreateCertificateStore = -1072824209,
        //
        // Summary:
        //     Message text: Unable to open the certificates store for the internal certificate.
        CannotOpenCertificateStore = -1072824208,
        //
        // Summary:
        //     Message text: The operation is invalid for a Message Queuing services object.
        IllegalEnterpriseOperation = -1072824207,
        //
        // Summary:
        //     Message text: Failed to grant the "Add Guid" permission to current user.
        CannotGrantAddGuid = -1072824206,
        //
        // Summary:
        //     Message text: Cannot load the MSMQOCM.DLL library.
        CannotLoadMsmqOcm = -1072824205,
        //
        // Summary:
        //     Message text: Cannot locate an entry point in the MSMQOCM.DLL library.
        NoEntryPointMsmqOcm = -1072824204,
        //
        // Summary:
        //     Message text: Failed to find Message Queuing servers on domain controllers.
        NoMsmqServersOnDc = -1072824203,
        //
        // Summary:
        //     Message text: Failed to join Message Queuing enterprise on Windows 2000 domain.
        CannotJoinDomain = -1072824202,
        //
        // Summary:
        //     Message text: Failed to create an object on a specified global catalog server.
        CannotCreateOnGlobalCatalog = -1072824201,
        //
        // Summary:
        //     Message text: Failed to create Message Queuing configuration object with a GUID
        //     that matches the computer installation. You must uninstall Message Queuing and
        //     then reinstall it.
        GuidNotMatching = -1072824200,
        //
        // Summary:
        //     Message text: Unable to find the public key for computer.
        PublicKeyNotFound = -1072824199,
        //
        // Summary:
        //     Message text: The public key for the computer does not exist.
        PublicKeyDoesNotExist = -1072824198,
        //
        // Summary:
        //     The private properties parameter value is invalid. This may be because it has
        //     a null value or has zero properties specified.
        IllegalPrivateProperties = -1072824197,
        //
        // Summary:
        //     Message text: Unable to find Global Catalog servers in the specified domain.
        NoGlobalCatalogInDomain = -1072824196,
        //
        // Summary:
        //     Message text: Failed to find Message Queuing servers on Global Catalog domain
        //     controllers.
        NoMsmqServersOnGlobalCatalog = -1072824195,
        //
        // Summary:
        //     Message text: Failed to retrieve the distinguished name of local computer.
        CannotGetDistinguishedName = -1072824194,
        //
        // Summary:
        //     Message text: Unable to hash data for an authenticated message.
        CannotHashDataEx = -1072824193,
        //
        // Summary:
        //     Message text: Unable to sign data before sending an authenticated message.
        CannotSignDataEx = -1072824192,
        //
        // Summary:
        //     Message text: Unable to create a hash object for an authenticated message.
        CannotCreateHashEx = -1072824191,
        //
        // Summary:
        //     Message text: Signature of received message is not valid.
        FailVerifySignatureEx = -1072824190,
        //
        // Summary:
        //     Message text: The specified message could not be found.
        MessageNotFound = -1072824184
    }
}