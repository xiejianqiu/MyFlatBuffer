// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OfflineReward : Table {
  public static FB_OfflineReward GetRootAsFB_OfflineReward(ByteBuffer _bb) { return GetRootAsFB_OfflineReward(_bb, new FB_OfflineReward()); }
  public static FB_OfflineReward GetRootAsFB_OfflineReward(ByteBuffer _bb, FB_OfflineReward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OfflineReward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SceneType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetRecAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RecAttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRecAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RecAttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int RecMinLv { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int RecMinDef { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int GetViewDroplevelList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ViewDroplevelListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetViewDropNumList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ViewDropNumListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public long StandardExp { get { int o = __offset(20); return o != 0 ? bb.GetLong(o + bb_pos) : (long)1; } }
  public int RecMinAttrpower { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int StandardAttrpower { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int GetDropBoxIDList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropBoxIDListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int KPM { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long YuanShenExp { get { int o = __offset(30); return o != 0 ? bb.GetLong(o + bb_pos) : (long)0; } }
  public int PlayerLv { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_OfflineReward> CreateFB_OfflineReward(FlatBufferBuilder builder,
      int Id = 0,
      int SceneType = 0,
      VectorOffset RecAttrIdList = default(VectorOffset),
      VectorOffset RecAttrValueList = default(VectorOffset),
      int RecMinLv = 1,
      int RecMinDef = 1,
      VectorOffset ViewDroplevelList = default(VectorOffset),
      VectorOffset ViewDropNumList = default(VectorOffset),
      long StandardExp = 1,
      int RecMinAttrpower = 1,
      int StandardAttrpower = 1,
      VectorOffset DropBoxIDList = default(VectorOffset),
      int KPM = 0,
      long YuanShenExp = 0,
      int PlayerLv = -1) {
    builder.StartObject(15);
    FB_OfflineReward.AddYuanShenExp(builder, YuanShenExp);
    FB_OfflineReward.AddStandardExp(builder, StandardExp);
    FB_OfflineReward.AddPlayerLv(builder, PlayerLv);
    FB_OfflineReward.AddKPM(builder, KPM);
    FB_OfflineReward.AddDropBoxIDList(builder, DropBoxIDList);
    FB_OfflineReward.AddStandardAttrpower(builder, StandardAttrpower);
    FB_OfflineReward.AddRecMinAttrpower(builder, RecMinAttrpower);
    FB_OfflineReward.AddViewDropNumList(builder, ViewDropNumList);
    FB_OfflineReward.AddViewDroplevelList(builder, ViewDroplevelList);
    FB_OfflineReward.AddRecMinDef(builder, RecMinDef);
    FB_OfflineReward.AddRecMinLv(builder, RecMinLv);
    FB_OfflineReward.AddRecAttrValueList(builder, RecAttrValueList);
    FB_OfflineReward.AddRecAttrIdList(builder, RecAttrIdList);
    FB_OfflineReward.AddSceneType(builder, SceneType);
    FB_OfflineReward.AddId(builder, Id);
    return FB_OfflineReward.EndFB_OfflineReward(builder);
  }

  public static void StartFB_OfflineReward(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSceneType(FlatBufferBuilder builder, int SceneType) { builder.AddInt(1, SceneType, 0); }
  public static void AddRecAttrIdList(FlatBufferBuilder builder, VectorOffset RecAttrIdListOffset) { builder.AddOffset(2, RecAttrIdListOffset.Value, 0); }
  public static VectorOffset CreateRecAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRecAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecAttrValueList(FlatBufferBuilder builder, VectorOffset RecAttrValueListOffset) { builder.AddOffset(3, RecAttrValueListOffset.Value, 0); }
  public static VectorOffset CreateRecAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRecAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRecMinLv(FlatBufferBuilder builder, int RecMinLv) { builder.AddInt(4, RecMinLv, 1); }
  public static void AddRecMinDef(FlatBufferBuilder builder, int RecMinDef) { builder.AddInt(5, RecMinDef, 1); }
  public static void AddViewDroplevelList(FlatBufferBuilder builder, VectorOffset ViewDroplevelListOffset) { builder.AddOffset(6, ViewDroplevelListOffset.Value, 0); }
  public static VectorOffset CreateViewDroplevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartViewDroplevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddViewDropNumList(FlatBufferBuilder builder, VectorOffset ViewDropNumListOffset) { builder.AddOffset(7, ViewDropNumListOffset.Value, 0); }
  public static VectorOffset CreateViewDropNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartViewDropNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStandardExp(FlatBufferBuilder builder, long StandardExp) { builder.AddLong(8, StandardExp, 1); }
  public static void AddRecMinAttrpower(FlatBufferBuilder builder, int RecMinAttrpower) { builder.AddInt(9, RecMinAttrpower, 1); }
  public static void AddStandardAttrpower(FlatBufferBuilder builder, int StandardAttrpower) { builder.AddInt(10, StandardAttrpower, 1); }
  public static void AddDropBoxIDList(FlatBufferBuilder builder, VectorOffset DropBoxIDListOffset) { builder.AddOffset(11, DropBoxIDListOffset.Value, 0); }
  public static VectorOffset CreateDropBoxIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropBoxIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddKPM(FlatBufferBuilder builder, int KPM) { builder.AddInt(12, KPM, 0); }
  public static void AddYuanShenExp(FlatBufferBuilder builder, long YuanShenExp) { builder.AddLong(13, YuanShenExp, 0); }
  public static void AddPlayerLv(FlatBufferBuilder builder, int PlayerLv) { builder.AddInt(14, PlayerLv, -1); }
  public static Offset<FB_OfflineReward> EndFB_OfflineReward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OfflineReward>(o);
  }
};

public sealed class FB_OfflineRewardContainer : Table {
  public static FB_OfflineRewardContainer GetRootAsFB_OfflineRewardContainer(ByteBuffer _bb) { return GetRootAsFB_OfflineRewardContainer(_bb, new FB_OfflineRewardContainer()); }
  public static FB_OfflineRewardContainer GetRootAsFB_OfflineRewardContainer(ByteBuffer _bb, FB_OfflineRewardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OfflineRewardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OfflineRewardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OfflineReward GetItems(int j) { return GetItems(new FB_OfflineReward(), j); }
  public FB_OfflineReward GetItems(FB_OfflineReward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OfflineRewardContainer> CreateFB_OfflineRewardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OfflineRewardContainer.AddItems(builder, items);
    return FB_OfflineRewardContainer.EndFB_OfflineRewardContainer(builder);
  }

  public static void StartFB_OfflineRewardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OfflineReward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OfflineRewardContainer> EndFB_OfflineRewardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OfflineRewardContainer>(o);
  }
  public static void FinishFB_OfflineRewardContainerBuffer(FlatBufferBuilder builder, Offset<FB_OfflineRewardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
