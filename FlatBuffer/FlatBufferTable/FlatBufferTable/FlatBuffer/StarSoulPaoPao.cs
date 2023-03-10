// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_StarSoulPaoPao : Table {
  public static FB_StarSoulPaoPao GetRootAsFB_StarSoulPaoPao(ByteBuffer _bb) { return GetRootAsFB_StarSoulPaoPao(_bb, new FB_StarSoulPaoPao()); }
  public static FB_StarSoulPaoPao GetRootAsFB_StarSoulPaoPao(ByteBuffer _bb, FB_StarSoulPaoPao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_StarSoulPaoPao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Text { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SceneID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LvlMin { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LvlMax { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_StarSoulPaoPao> CreateFB_StarSoulPaoPao(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Text = default(StringOffset),
      int SceneID = -1,
      int Weight = -1,
      int LvlMin = -1,
      int LvlMax = -1) {
    builder.StartObject(6);
    FB_StarSoulPaoPao.AddLvlMax(builder, LvlMax);
    FB_StarSoulPaoPao.AddLvlMin(builder, LvlMin);
    FB_StarSoulPaoPao.AddWeight(builder, Weight);
    FB_StarSoulPaoPao.AddSceneID(builder, SceneID);
    FB_StarSoulPaoPao.AddText(builder, Text);
    FB_StarSoulPaoPao.AddID(builder, ID);
    return FB_StarSoulPaoPao.EndFB_StarSoulPaoPao(builder);
  }

  public static void StartFB_StarSoulPaoPao(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddText(FlatBufferBuilder builder, StringOffset TextOffset) { builder.AddOffset(1, TextOffset.Value, 0); }
  public static void AddSceneID(FlatBufferBuilder builder, int SceneID) { builder.AddInt(2, SceneID, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(3, Weight, -1); }
  public static void AddLvlMin(FlatBufferBuilder builder, int LvlMin) { builder.AddInt(4, LvlMin, -1); }
  public static void AddLvlMax(FlatBufferBuilder builder, int LvlMax) { builder.AddInt(5, LvlMax, -1); }
  public static Offset<FB_StarSoulPaoPao> EndFB_StarSoulPaoPao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulPaoPao>(o);
  }
};

public sealed class FB_StarSoulPaoPaoContainer : Table {
  public static FB_StarSoulPaoPaoContainer GetRootAsFB_StarSoulPaoPaoContainer(ByteBuffer _bb) { return GetRootAsFB_StarSoulPaoPaoContainer(_bb, new FB_StarSoulPaoPaoContainer()); }
  public static FB_StarSoulPaoPaoContainer GetRootAsFB_StarSoulPaoPaoContainer(ByteBuffer _bb, FB_StarSoulPaoPaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_StarSoulPaoPaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_StarSoulPaoPaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_StarSoulPaoPao GetItems(int j) { return GetItems(new FB_StarSoulPaoPao(), j); }
  public FB_StarSoulPaoPao GetItems(FB_StarSoulPaoPao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_StarSoulPaoPaoContainer> CreateFB_StarSoulPaoPaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_StarSoulPaoPaoContainer.AddItems(builder, items);
    return FB_StarSoulPaoPaoContainer.EndFB_StarSoulPaoPaoContainer(builder);
  }

  public static void StartFB_StarSoulPaoPaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_StarSoulPaoPao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_StarSoulPaoPaoContainer> EndFB_StarSoulPaoPaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_StarSoulPaoPaoContainer>(o);
  }
  public static void FinishFB_StarSoulPaoPaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_StarSoulPaoPaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
