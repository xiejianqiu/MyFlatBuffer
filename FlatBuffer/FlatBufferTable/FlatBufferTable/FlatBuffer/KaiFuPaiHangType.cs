// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KaiFuPaiHangType : Table {
  public static FB_KaiFuPaiHangType GetRootAsFB_KaiFuPaiHangType(ByteBuffer _bb) { return GetRootAsFB_KaiFuPaiHangType(_bb, new FB_KaiFuPaiHangType()); }
  public static FB_KaiFuPaiHangType GetRootAsFB_KaiFuPaiHangType(ByteBuffer _bb, FB_KaiFuPaiHangType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KaiFuPaiHangType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetGoalList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int GoalListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public string Label { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int PaiHangIndex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardByJobList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardByJobListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public string GetRewardByJobNameList(int j) { int o = __offset(14); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int RewardByJobNameListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string GetRewardNameList(int j) { int o = __offset(20); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int RewardNameListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsBind { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_KaiFuPaiHangType> CreateFB_KaiFuPaiHangType(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset GoalList = default(VectorOffset),
      StringOffset Label = default(StringOffset),
      int PaiHangIndex = -1,
      VectorOffset RewardByJobList = default(VectorOffset),
      VectorOffset RewardByJobNameList = default(VectorOffset),
      VectorOffset RewardList = default(VectorOffset),
      VectorOffset RewardNumList = default(VectorOffset),
      VectorOffset RewardNameList = default(VectorOffset),
      bool IsBind = false) {
    builder.StartObject(10);
    FB_KaiFuPaiHangType.AddRewardNameList(builder, RewardNameList);
    FB_KaiFuPaiHangType.AddRewardNumList(builder, RewardNumList);
    FB_KaiFuPaiHangType.AddRewardList(builder, RewardList);
    FB_KaiFuPaiHangType.AddRewardByJobNameList(builder, RewardByJobNameList);
    FB_KaiFuPaiHangType.AddRewardByJobList(builder, RewardByJobList);
    FB_KaiFuPaiHangType.AddPaiHangIndex(builder, PaiHangIndex);
    FB_KaiFuPaiHangType.AddLabel(builder, Label);
    FB_KaiFuPaiHangType.AddGoalList(builder, GoalList);
    FB_KaiFuPaiHangType.AddID(builder, ID);
    FB_KaiFuPaiHangType.AddIsBind(builder, IsBind);
    return FB_KaiFuPaiHangType.EndFB_KaiFuPaiHangType(builder);
  }

  public static void StartFB_KaiFuPaiHangType(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGoalList(FlatBufferBuilder builder, VectorOffset GoalListOffset) { builder.AddOffset(1, GoalListOffset.Value, 0); }
  public static VectorOffset CreateGoalListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartGoalListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLabel(FlatBufferBuilder builder, StringOffset LabelOffset) { builder.AddOffset(2, LabelOffset.Value, 0); }
  public static void AddPaiHangIndex(FlatBufferBuilder builder, int PaiHangIndex) { builder.AddInt(3, PaiHangIndex, -1); }
  public static void AddRewardByJobList(FlatBufferBuilder builder, VectorOffset RewardByJobListOffset) { builder.AddOffset(4, RewardByJobListOffset.Value, 0); }
  public static VectorOffset CreateRewardByJobListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardByJobListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardByJobNameList(FlatBufferBuilder builder, VectorOffset RewardByJobNameListOffset) { builder.AddOffset(5, RewardByJobNameListOffset.Value, 0); }
  public static VectorOffset CreateRewardByJobNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartRewardByJobNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardList(FlatBufferBuilder builder, VectorOffset RewardListOffset) { builder.AddOffset(6, RewardListOffset.Value, 0); }
  public static VectorOffset CreateRewardListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNumList(FlatBufferBuilder builder, VectorOffset RewardNumListOffset) { builder.AddOffset(7, RewardNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardNameList(FlatBufferBuilder builder, VectorOffset RewardNameListOffset) { builder.AddOffset(8, RewardNameListOffset.Value, 0); }
  public static VectorOffset CreateRewardNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartRewardNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsBind(FlatBufferBuilder builder, bool IsBind) { builder.AddBool(9, IsBind, false); }
  public static Offset<FB_KaiFuPaiHangType> EndFB_KaiFuPaiHangType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KaiFuPaiHangType>(o);
  }
};

public sealed class FB_KaiFuPaiHangTypeContainer : Table {
  public static FB_KaiFuPaiHangTypeContainer GetRootAsFB_KaiFuPaiHangTypeContainer(ByteBuffer _bb) { return GetRootAsFB_KaiFuPaiHangTypeContainer(_bb, new FB_KaiFuPaiHangTypeContainer()); }
  public static FB_KaiFuPaiHangTypeContainer GetRootAsFB_KaiFuPaiHangTypeContainer(ByteBuffer _bb, FB_KaiFuPaiHangTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KaiFuPaiHangTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KaiFuPaiHangTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KaiFuPaiHangType GetItems(int j) { return GetItems(new FB_KaiFuPaiHangType(), j); }
  public FB_KaiFuPaiHangType GetItems(FB_KaiFuPaiHangType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KaiFuPaiHangTypeContainer> CreateFB_KaiFuPaiHangTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KaiFuPaiHangTypeContainer.AddItems(builder, items);
    return FB_KaiFuPaiHangTypeContainer.EndFB_KaiFuPaiHangTypeContainer(builder);
  }

  public static void StartFB_KaiFuPaiHangTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KaiFuPaiHangType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KaiFuPaiHangTypeContainer> EndFB_KaiFuPaiHangTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KaiFuPaiHangTypeContainer>(o);
  }
  public static void FinishFB_KaiFuPaiHangTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_KaiFuPaiHangTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
