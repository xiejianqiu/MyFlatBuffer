// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FlyCutterUI : Table {
  public static FB_FlyCutterUI GetRootAsFB_FlyCutterUI(ByteBuffer _bb) { return GetRootAsFB_FlyCutterUI(_bb, new FB_FlyCutterUI()); }
  public static FB_FlyCutterUI GetRootAsFB_FlyCutterUI(ByteBuffer _bb, FB_FlyCutterUI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FlyCutterUI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Level { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TimeLinit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int KnifeNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float KnifeFlyTime { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public string GetBombAniNameList(int j) { int o = __offset(12); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int BombAniNameListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public string GetMosterAniNameList(int j) { int o = __offset(14); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int MosterAniNameListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public string GetBombSpriteNameList(int j) { int o = __offset(16); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int BombSpriteNameListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public string GetMosterSpriteNameList(int j) { int o = __offset(18); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int MosterSpriteNameListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FlyCutterUI> CreateFB_FlyCutterUI(FlatBufferBuilder builder,
      int Level = 0,
      int TimeLinit = 0,
      int KnifeNum = 0,
      float KnifeFlyTime = 0,
      VectorOffset BombAniNameList = default(VectorOffset),
      VectorOffset MosterAniNameList = default(VectorOffset),
      VectorOffset BombSpriteNameList = default(VectorOffset),
      VectorOffset MosterSpriteNameList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_FlyCutterUI.AddMosterSpriteNameList(builder, MosterSpriteNameList);
    FB_FlyCutterUI.AddBombSpriteNameList(builder, BombSpriteNameList);
    FB_FlyCutterUI.AddMosterAniNameList(builder, MosterAniNameList);
    FB_FlyCutterUI.AddBombAniNameList(builder, BombAniNameList);
    FB_FlyCutterUI.AddKnifeFlyTime(builder, KnifeFlyTime);
    FB_FlyCutterUI.AddKnifeNum(builder, KnifeNum);
    FB_FlyCutterUI.AddTimeLinit(builder, TimeLinit);
    FB_FlyCutterUI.AddLevel(builder, Level);
    return FB_FlyCutterUI.EndFB_FlyCutterUI(builder);
  }

  public static void StartFB_FlyCutterUI(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(0, Level, 0); }
  public static void AddTimeLinit(FlatBufferBuilder builder, int TimeLinit) { builder.AddInt(1, TimeLinit, 0); }
  public static void AddKnifeNum(FlatBufferBuilder builder, int KnifeNum) { builder.AddInt(2, KnifeNum, 0); }
  public static void AddKnifeFlyTime(FlatBufferBuilder builder, float KnifeFlyTime) { builder.AddFloat(3, KnifeFlyTime, 0); }
  public static void AddBombAniNameList(FlatBufferBuilder builder, VectorOffset BombAniNameListOffset) { builder.AddOffset(4, BombAniNameListOffset.Value, 0); }
  public static VectorOffset CreateBombAniNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBombAniNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMosterAniNameList(FlatBufferBuilder builder, VectorOffset MosterAniNameListOffset) { builder.AddOffset(5, MosterAniNameListOffset.Value, 0); }
  public static VectorOffset CreateMosterAniNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartMosterAniNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBombSpriteNameList(FlatBufferBuilder builder, VectorOffset BombSpriteNameListOffset) { builder.AddOffset(6, BombSpriteNameListOffset.Value, 0); }
  public static VectorOffset CreateBombSpriteNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBombSpriteNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMosterSpriteNameList(FlatBufferBuilder builder, VectorOffset MosterSpriteNameListOffset) { builder.AddOffset(7, MosterSpriteNameListOffset.Value, 0); }
  public static VectorOffset CreateMosterSpriteNameListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartMosterSpriteNameListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FlyCutterUI> EndFB_FlyCutterUI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FlyCutterUI>(o);
  }
};

public sealed class FB_FlyCutterUIContainer : Table {
  public static FB_FlyCutterUIContainer GetRootAsFB_FlyCutterUIContainer(ByteBuffer _bb) { return GetRootAsFB_FlyCutterUIContainer(_bb, new FB_FlyCutterUIContainer()); }
  public static FB_FlyCutterUIContainer GetRootAsFB_FlyCutterUIContainer(ByteBuffer _bb, FB_FlyCutterUIContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FlyCutterUIContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FlyCutterUIContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FlyCutterUI GetItems(int j) { return GetItems(new FB_FlyCutterUI(), j); }
  public FB_FlyCutterUI GetItems(FB_FlyCutterUI obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FlyCutterUIContainer> CreateFB_FlyCutterUIContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FlyCutterUIContainer.AddItems(builder, items);
    return FB_FlyCutterUIContainer.EndFB_FlyCutterUIContainer(builder);
  }

  public static void StartFB_FlyCutterUIContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FlyCutterUI>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FlyCutterUIContainer> EndFB_FlyCutterUIContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FlyCutterUIContainer>(o);
  }
  public static void FinishFB_FlyCutterUIContainerBuffer(FlatBufferBuilder builder, Offset<FB_FlyCutterUIContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
