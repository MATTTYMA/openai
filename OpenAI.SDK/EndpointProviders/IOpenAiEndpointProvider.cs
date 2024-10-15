﻿using Betalgo.OpenAI.ObjectModels.RequestModels;

namespace Betalgo.OpenAI.EndpointProviders;

internal interface IOpenAIEndpointProvider
{
    string ModelRetrieve(string model);
    string CompletionCreate();
    string EditCreate();
    string ModelsList();
    string ModelsDelete(string modelId);
    string FilesList();
    string FilesUpload();
    string FileDelete(string fileId);
    string FileRetrieve(string fileId);
    string FileRetrieveContent(string fileId);
    string FineTuneCreate();
    string FineTuneList();
    string FineTuneRetrieve(string fineTuneId);
    string FineTuneCancel(string fineTuneId);
    string FineTuneListEvents(string fineTuneId);
    string FineTuneDelete(string fineTuneId);
    string FineTuningJobCreate();
    string FineTuningJobList(FineTuningJobListRequest? fineTuningJobListRequest);
    string FineTuningJobRetrieve(string fineTuningJobId);
    string FineTuningJobCancel(string fineTuningJobId);
    string FineTuningJobListEvents(string fineTuningJobId);
    string EmbeddingCreate();
    string ModerationCreate();
    string ImageCreate();
    string ImageEditCreate();
    string ImageVariationCreate();
    string ChatCompletionCreate();
    string AudioCreateTranscription();
    string AudioCreateTranslation();
    string AudioCreateSpeech();
    string BatchCreate();
    string BatchRetrieve(string batchId);
    string BatchCancel(string batchId);

    string AssistantCreate();
    string AssistantRetrieve(string assistantId);
    string AssistantModify(string assistantId);
    string AssistantDelete(string assistantId);
    string AssistantList(PaginationRequest? assistantListRequest);
    string AssistantFileCreate(string assistantId);
    string AssistantFileRetrieve(string assistantId, string fileId);
    string AssistantFileDelete(string assistantId, string fileId);
    string AssistantFileList(string assistantId, PaginationRequest? assistantFileListRequest);
    string ThreadCreate();
    string ThreadRetrieve(string threadId);
    string ThreadModify(string threadId);
    string ThreadDelete(string threadId);
    string MessageCreate(string threadId);
    string MessageRetrieve(string threadId, string messageId);
    string MessageModify(string threadId, string messageId);
    string MessageList(string threadId, PaginationRequest? messageListRequest);
    string RunCreate(string threadId);
    string RunRetrieve(string threadId, string runId);
    string RunModify(string threadId, string runId);
    string RunList(string threadId, PaginationRequest? runListRequest);
    string RunSubmitToolOutputs(string threadId, string runId);
    string RunCancel(string threadId, string runId);
    string ThreadAndRunCreate();
    string RunStepRetrieve(string threadId, string runId, string stepId);
    string RunStepList(string threadId, string runId, PaginationRequest? runStepListRequest);
    string VectorStoreCreate();
    string VectorStoreList(PaginationRequest baseListRequest);
    string VectorStoreRetrieve(string vectorStoreId);
    string VectorStoreModify(string vectorStoreId);
    string VectorStoreDelete(string vectorStoreId);
    string VectorStoreFileCreate(string vectorStoreId);
    string VectorStoreFileRetrieve(string vectorStoreId, string fileId);
    string VectorStoreFileDelete(string vectorStoreId, string fileId);
    string VectorStoreFileList(string vectorStoreId, VectorStoreFileListRequest? baseListRequest);
    string VectorStoreFileBatchCreate(string vectorStoreId);
    string VectorStoreFileBatchRetrieve(string vectorStoreId, string batchId);
    string VectorStoreFileBatchCancel(string vectorStoreId, string batchId);
    string VectorStoreFileBatchList(string vectorStoreId, string batchId, PaginationRequest? baseListRequest);
    string MessageDelete(string threadId, string messageId);
}