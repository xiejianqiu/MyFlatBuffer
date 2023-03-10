// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RewardSurveyConfig : Table {
  public static FB_RewardSurveyConfig GetRootAsFB_RewardSurveyConfig(ByteBuffer _bb) { return GetRootAsFB_RewardSurveyConfig(_bb, new FB_RewardSurveyConfig()); }
  public static FB_RewardSurveyConfig GetRootAsFB_RewardSurveyConfig(ByteBuffer _bb, FB_RewardSurveyConfig obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RewardSurveyConfig __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ActCycle { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TitleNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AnswerStartID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Money { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Price { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetEndRewardIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndRewardIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetEndRewardNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int EndRewardNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RewardSurveyConfig> CreateFB_RewardSurveyConfig(FlatBufferBuilder builder,
      int ID = 0,
      int ActCycle = -1,
      int TitleNum = -1,
      int AnswerStartID = -1,
      int Money = -1,
      int Price = -1,
      VectorOffset EndRewardIDList = default(VectorOffset),
      VectorOffset EndRewardNumList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_RewardSurveyConfig.AddEndRewardNumList(builder, EndRewardNumList);
    FB_RewardSurveyConfig.AddEndRewardIDList(builder, EndRewardIDList);
    FB_RewardSurveyConfig.AddPrice(builder, Price);
    FB_RewardSurveyConfig.AddMoney(builder, Money);
    FB_RewardSurveyConfig.AddAnswerStartID(builder, AnswerStartID);
    FB_RewardSurveyConfig.AddTitleNum(builder, TitleNum);
    FB_RewardSurveyConfig.AddActCycle(builder, ActCycle);
    FB_RewardSurveyConfig.AddID(builder, ID);
    return FB_RewardSurveyConfig.EndFB_RewardSurveyConfig(builder);
  }

  public static void StartFB_RewardSurveyConfig(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddActCycle(FlatBufferBuilder builder, int ActCycle) { builder.AddInt(1, ActCycle, -1); }
  public static void AddTitleNum(FlatBufferBuilder builder, int TitleNum) { builder.AddInt(2, TitleNum, -1); }
  public static void AddAnswerStartID(FlatBufferBuilder builder, int AnswerStartID) { builder.AddInt(3, AnswerStartID, -1); }
  public static void AddMoney(FlatBufferBuilder builder, int Money) { builder.AddInt(4, Money, -1); }
  public static void AddPrice(FlatBufferBuilder builder, int Price) { builder.AddInt(5, Price, -1); }
  public static void AddEndRewardIDList(FlatBufferBuilder builder, VectorOffset EndRewardIDListOffset) { builder.AddOffset(6, EndRewardIDListOffset.Value, 0); }
  public static VectorOffset CreateEndRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEndRewardNumList(FlatBufferBuilder builder, VectorOffset EndRewardNumListOffset) { builder.AddOffset(7, EndRewardNumListOffset.Value, 0); }
  public static VectorOffset CreateEndRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartEndRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RewardSurveyConfig> EndFB_RewardSurveyConfig(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RewardSurveyConfig>(o);
  }
};

public sealed class FB_RewardSurveyConfigContainer : Table {
  public static FB_RewardSurveyConfigContainer GetRootAsFB_RewardSurveyConfigContainer(ByteBuffer _bb) { return GetRootAsFB_RewardSurveyConfigContainer(_bb, new FB_RewardSurveyConfigContainer()); }
  public static FB_RewardSurveyConfigContainer GetRootAsFB_RewardSurveyConfigContainer(ByteBuffer _bb, FB_RewardSurveyConfigContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RewardSurveyConfigContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RewardSurveyConfigContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RewardSurveyConfig GetItems(int j) { return GetItems(new FB_RewardSurveyConfig(), j); }
  public FB_RewardSurveyConfig GetItems(FB_RewardSurveyConfig obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RewardSurveyConfigContainer> CreateFB_RewardSurveyConfigContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RewardSurveyConfigContainer.AddItems(builder, items);
    return FB_RewardSurveyConfigContainer.EndFB_RewardSurveyConfigContainer(builder);
  }

  public static void StartFB_RewardSurveyConfigContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RewardSurveyConfig>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RewardSurveyConfigContainer> EndFB_RewardSurveyConfigContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RewardSurveyConfigContainer>(o);
  }
  public static void FinishFB_RewardSurveyConfigContainerBuffer(FlatBufferBuilder builder, Offset<FB_RewardSurveyConfigContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
