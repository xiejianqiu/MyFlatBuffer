// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionSectionReward : Table {
  public static FB_MissionSectionReward GetRootAsFB_MissionSectionReward(ByteBuffer _bb) { return GetRootAsFB_MissionSectionReward(_bb, new FB_MissionSectionReward()); }
  public static FB_MissionSectionReward GetRootAsFB_MissionSectionReward(ByteBuffer _bb, FB_MissionSectionReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionSectionReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string SectionOrder { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SectionDesc { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetRewardItemIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardItemNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardItemNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public bool GetShowEffectList(int j) { int o = __offset(18); return o != 0 ? 0!=bb.Get(__vector(o) + j * 1) : false; }
  public int ShowEffectListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string RewardTips { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_MissionSectionReward> CreateFB_MissionSectionReward(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset SectionOrder = default(StringOffset),
      StringOffset Name = default(StringOffset),
      StringOffset SectionDesc = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      VectorOffset RewardItemIDList = default(VectorOffset),
      VectorOffset RewardItemNumList = default(VectorOffset),
      VectorOffset ShowEffectList = default(VectorOffset),
      StringOffset RewardTips = default(StringOffset)) {
    builder.StartObject(9);
    FB_MissionSectionReward.AddRewardTips(builder, RewardTips);
    FB_MissionSectionReward.AddShowEffectList(builder, ShowEffectList);
    FB_MissionSectionReward.AddRewardItemNumList(builder, RewardItemNumList);
    FB_MissionSectionReward.AddRewardItemIDList(builder, RewardItemIDList);
    FB_MissionSectionReward.AddIcon(builder, Icon);
    FB_MissionSectionReward.AddSectionDesc(builder, SectionDesc);
    FB_MissionSectionReward.AddName(builder, Name);
    FB_MissionSectionReward.AddSectionOrder(builder, SectionOrder);
    FB_MissionSectionReward.AddID(builder, ID);
    return FB_MissionSectionReward.EndFB_MissionSectionReward(builder);
  }

  public static void StartFB_MissionSectionReward(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSectionOrder(FlatBufferBuilder builder, StringOffset SectionOrderOffset) { builder.AddOffset(1, SectionOrderOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddSectionDesc(FlatBufferBuilder builder, StringOffset SectionDescOffset) { builder.AddOffset(3, SectionDescOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(4, IconOffset.Value, 0); }
  public static void AddRewardItemIDList(FlatBufferBuilder builder, VectorOffset RewardItemIDListOffset) { builder.AddOffset(5, RewardItemIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardItemNumList(FlatBufferBuilder builder, VectorOffset RewardItemNumListOffset) { builder.AddOffset(6, RewardItemNumListOffset.Value, 0); }
  public static VectorOffset CreateRewardItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowEffectList(FlatBufferBuilder builder, VectorOffset ShowEffectListOffset) { builder.AddOffset(7, ShowEffectListOffset.Value, 0); }
  public static VectorOffset CreateShowEffectListVector(FlatBufferBuilder builder, bool[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddBool(data[i]); return builder.EndVector(); }
  public static void StartShowEffectListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddRewardTips(FlatBufferBuilder builder, StringOffset RewardTipsOffset) { builder.AddOffset(8, RewardTipsOffset.Value, 0); }
  public static Offset<FB_MissionSectionReward> EndFB_MissionSectionReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionSectionReward>(o);
  }
};

public sealed class FB_MissionSectionRewardContainer : Table {
  public static FB_MissionSectionRewardContainer GetRootAsFB_MissionSectionRewardContainer(ByteBuffer _bb) { return GetRootAsFB_MissionSectionRewardContainer(_bb, new FB_MissionSectionRewardContainer()); }
  public static FB_MissionSectionRewardContainer GetRootAsFB_MissionSectionRewardContainer(ByteBuffer _bb, FB_MissionSectionRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionSectionRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionSectionRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionSectionReward GetItems(int j) { return GetItems(new FB_MissionSectionReward(), j); }
  public FB_MissionSectionReward GetItems(FB_MissionSectionReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionSectionRewardContainer> CreateFB_MissionSectionRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionSectionRewardContainer.AddItems(builder, items);
    return FB_MissionSectionRewardContainer.EndFB_MissionSectionRewardContainer(builder);
  }

  public static void StartFB_MissionSectionRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionSectionReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionSectionRewardContainer> EndFB_MissionSectionRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionSectionRewardContainer>(o);
  }
  public static void FinishFB_MissionSectionRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionSectionRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
