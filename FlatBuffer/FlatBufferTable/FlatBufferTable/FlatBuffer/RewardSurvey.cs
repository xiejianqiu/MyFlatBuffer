// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RewardSurvey : Table {
  public static FB_RewardSurvey GetRootAsFB_RewardSurvey(ByteBuffer _bb) { return GetRootAsFB_RewardSurvey(_bb, new FB_RewardSurvey()); }
  public static FB_RewardSurvey GetRootAsFB_RewardSurvey(ByteBuffer _bb, FB_RewardSurvey obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RewardSurvey __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TitleID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SelNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OperationNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkipTitle { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InputNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetInputLengthList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int InputLengthListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAnswerIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AnswerIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSkipIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkipIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RewardSurvey> CreateFB_RewardSurvey(FlatBufferBuilder builder,
      int ID = 0,
      int TitleID = -1,
      int SelNum = -1,
      int OperationNum = -1,
      int NextID = -1,
      int SkipTitle = -1,
      int InputNum = -1,
      VectorOffset InputLengthList = default(VectorOffset),
      VectorOffset AnswerIDList = default(VectorOffset),
      VectorOffset SkipIDList = default(VectorOffset)) {
    builder.StartObject(10);
    FB_RewardSurvey.AddSkipIDList(builder, SkipIDList);
    FB_RewardSurvey.AddAnswerIDList(builder, AnswerIDList);
    FB_RewardSurvey.AddInputLengthList(builder, InputLengthList);
    FB_RewardSurvey.AddInputNum(builder, InputNum);
    FB_RewardSurvey.AddSkipTitle(builder, SkipTitle);
    FB_RewardSurvey.AddNextID(builder, NextID);
    FB_RewardSurvey.AddOperationNum(builder, OperationNum);
    FB_RewardSurvey.AddSelNum(builder, SelNum);
    FB_RewardSurvey.AddTitleID(builder, TitleID);
    FB_RewardSurvey.AddID(builder, ID);
    return FB_RewardSurvey.EndFB_RewardSurvey(builder);
  }

  public static void StartFB_RewardSurvey(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTitleID(FlatBufferBuilder builder, int TitleID) { builder.AddInt(1, TitleID, -1); }
  public static void AddSelNum(FlatBufferBuilder builder, int SelNum) { builder.AddInt(2, SelNum, -1); }
  public static void AddOperationNum(FlatBufferBuilder builder, int OperationNum) { builder.AddInt(3, OperationNum, -1); }
  public static void AddNextID(FlatBufferBuilder builder, int NextID) { builder.AddInt(4, NextID, -1); }
  public static void AddSkipTitle(FlatBufferBuilder builder, int SkipTitle) { builder.AddInt(5, SkipTitle, -1); }
  public static void AddInputNum(FlatBufferBuilder builder, int InputNum) { builder.AddInt(6, InputNum, -1); }
  public static void AddInputLengthList(FlatBufferBuilder builder, VectorOffset InputLengthListOffset) { builder.AddOffset(7, InputLengthListOffset.Value, 0); }
  public static VectorOffset CreateInputLengthListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartInputLengthListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAnswerIDList(FlatBufferBuilder builder, VectorOffset AnswerIDListOffset) { builder.AddOffset(8, AnswerIDListOffset.Value, 0); }
  public static VectorOffset CreateAnswerIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAnswerIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkipIDList(FlatBufferBuilder builder, VectorOffset SkipIDListOffset) { builder.AddOffset(9, SkipIDListOffset.Value, 0); }
  public static VectorOffset CreateSkipIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkipIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RewardSurvey> EndFB_RewardSurvey(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RewardSurvey>(o);
  }
};

public sealed class FB_RewardSurveyContainer : Table {
  public static FB_RewardSurveyContainer GetRootAsFB_RewardSurveyContainer(ByteBuffer _bb) { return GetRootAsFB_RewardSurveyContainer(_bb, new FB_RewardSurveyContainer()); }
  public static FB_RewardSurveyContainer GetRootAsFB_RewardSurveyContainer(ByteBuffer _bb, FB_RewardSurveyContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RewardSurveyContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RewardSurveyContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RewardSurvey GetItems(int j) { return GetItems(new FB_RewardSurvey(), j); }
  public FB_RewardSurvey GetItems(FB_RewardSurvey obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RewardSurveyContainer> CreateFB_RewardSurveyContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RewardSurveyContainer.AddItems(builder, items);
    return FB_RewardSurveyContainer.EndFB_RewardSurveyContainer(builder);
  }

  public static void StartFB_RewardSurveyContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RewardSurvey>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RewardSurveyContainer> EndFB_RewardSurveyContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RewardSurveyContainer>(o);
  }
  public static void FinishFB_RewardSurveyContainerBuffer(FlatBufferBuilder builder, Offset<FB_RewardSurveyContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
