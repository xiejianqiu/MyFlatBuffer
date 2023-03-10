// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StrLoading : Table {
  public static FB_StrLoading GetRootAsFB_StrLoading(ByteBuffer _bb) { return GetRootAsFB_StrLoading(_bb, new FB_StrLoading()); }
  public static FB_StrLoading GetRootAsFB_StrLoading(ByteBuffer _bb, FB_StrLoading obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StrLoading __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Text { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LvlMin { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LvlMax { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvanceMin { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvanceMax { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VIPMin { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int VIPMax { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StrLoading> CreateFB_StrLoading(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Text = default(StringOffset),
      int SceneID = -1,
      int Weight = -1,
      int LvlMin = -1,
      int LvlMax = -1,
      int AdvanceMin = -1,
      int AdvanceMax = -1,
      int VIPMin = -1,
      int VIPMax = -1) {
    builder.StartObject(10);
    FB_StrLoading.AddVIPMax(builder, VIPMax);
    FB_StrLoading.AddVIPMin(builder, VIPMin);
    FB_StrLoading.AddAdvanceMax(builder, AdvanceMax);
    FB_StrLoading.AddAdvanceMin(builder, AdvanceMin);
    FB_StrLoading.AddLvlMax(builder, LvlMax);
    FB_StrLoading.AddLvlMin(builder, LvlMin);
    FB_StrLoading.AddWeight(builder, Weight);
    FB_StrLoading.AddSceneID(builder, SceneID);
    FB_StrLoading.AddText(builder, Text);
    FB_StrLoading.AddID(builder, ID);
    return FB_StrLoading.EndFB_StrLoading(builder);
  }

  public static void StartFB_StrLoading(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddText(FlatBufferBuilder builder, StringOffset TextOffset) { builder.AddOffset(1, TextOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(3, Weight, -1); }
  public static void AddLvlMin(FlatBufferBuilder builder, int LvlMin) { builder.AddInt(4, LvlMin, -1); }
  public static void AddLvlMax(FlatBufferBuilder builder, int LvlMax) { builder.AddInt(5, LvlMax, -1); }
  public static void AddAdvanceMin(FlatBufferBuilder builder, int AdvanceMin) { builder.AddInt(6, AdvanceMin, -1); }
  public static void AddAdvanceMax(FlatBufferBuilder builder, int AdvanceMax) { builder.AddInt(7, AdvanceMax, -1); }
  public static void AddVIPMin(FlatBufferBuilder builder, int VIPMin) { builder.AddInt(8, VIPMin, -1); }
  public static void AddVIPMax(FlatBufferBuilder builder, int VIPMax) { builder.AddInt(9, VIPMax, -1); }
  public static Offset<FB_StrLoading> EndFB_StrLoading(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrLoading>(o);
  }
};

public sealed class FB_StrLoadingContainer : Table {
  public static FB_StrLoadingContainer GetRootAsFB_StrLoadingContainer(ByteBuffer _bb) { return GetRootAsFB_StrLoadingContainer(_bb, new FB_StrLoadingContainer()); }
  public static FB_StrLoadingContainer GetRootAsFB_StrLoadingContainer(ByteBuffer _bb, FB_StrLoadingContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StrLoadingContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StrLoadingContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StrLoading GetItems(int j) { return GetItems(new FB_StrLoading(), j); }
  public FB_StrLoading GetItems(FB_StrLoading obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StrLoadingContainer> CreateFB_StrLoadingContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StrLoadingContainer.AddItems(builder, items);
    return FB_StrLoadingContainer.EndFB_StrLoadingContainer(builder);
  }

  public static void StartFB_StrLoadingContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StrLoading>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StrLoadingContainer> EndFB_StrLoadingContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StrLoadingContainer>(o);
  }
  public static void FinishFB_StrLoadingContainerBuffer(FlatBufferBuilder builder, Offset<FB_StrLoadingContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
