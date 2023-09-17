// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EffectPoint : Table {
  public static FB_EffectPoint GetRootAsFB_EffectPoint(ByteBuffer _bb) { return GetRootAsFB_EffectPoint(_bb, new FB_EffectPoint()); }
  public static FB_EffectPoint GetRootAsFB_EffectPoint(ByteBuffer _bb, FB_EffectPoint obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EffectPoint __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ModelTypeId { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CenterPointPath { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string HeadPointPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LHandPointPath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RHandPointPath { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LFootPointPath { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RFootPointPath { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string LUpperArmPointPath { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string WingPointPath { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ShenQiPointPath { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string WeaponPointPath { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_EffectPoint> CreateFB_EffectPoint(FlatBufferBuilder builder,
      int ModelTypeId = 0,
      StringOffset CenterPointPath = default(StringOffset),
      StringOffset HeadPointPath = default(StringOffset),
      StringOffset LHandPointPath = default(StringOffset),
      StringOffset RHandPointPath = default(StringOffset),
      StringOffset LFootPointPath = default(StringOffset),
      StringOffset RFootPointPath = default(StringOffset),
      StringOffset LUpperArmPointPath = default(StringOffset),
      StringOffset WingPointPath = default(StringOffset),
      StringOffset ShenQiPointPath = default(StringOffset),
      StringOffset WeaponPointPath = default(StringOffset)) {
    builder.StartObject(11);
    FB_EffectPoint.AddWeaponPointPath(builder, WeaponPointPath);
    FB_EffectPoint.AddShenQiPointPath(builder, ShenQiPointPath);
    FB_EffectPoint.AddWingPointPath(builder, WingPointPath);
    FB_EffectPoint.AddLUpperArmPointPath(builder, LUpperArmPointPath);
    FB_EffectPoint.AddRFootPointPath(builder, RFootPointPath);
    FB_EffectPoint.AddLFootPointPath(builder, LFootPointPath);
    FB_EffectPoint.AddRHandPointPath(builder, RHandPointPath);
    FB_EffectPoint.AddLHandPointPath(builder, LHandPointPath);
    FB_EffectPoint.AddHeadPointPath(builder, HeadPointPath);
    FB_EffectPoint.AddCenterPointPath(builder, CenterPointPath);
    FB_EffectPoint.AddModelTypeId(builder, ModelTypeId);
    return FB_EffectPoint.EndFB_EffectPoint(builder);
  }

  public static void StartFB_EffectPoint(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddModelTypeId(FlatBufferBuilder builder, int ModelTypeId) { builder.AddInt(0, ModelTypeId, 0); }
  public static void AddCenterPointPath(FlatBufferBuilder builder, StringOffset CenterPointPathOffset) { builder.AddOffset(1, CenterPointPathOffset.Value, 0); }
  public static void AddHeadPointPath(FlatBufferBuilder builder, StringOffset HeadPointPathOffset) { builder.AddOffset(2, HeadPointPathOffset.Value, 0); }
  public static void AddLHandPointPath(FlatBufferBuilder builder, StringOffset LHandPointPathOffset) { builder.AddOffset(3, LHandPointPathOffset.Value, 0); }
  public static void AddRHandPointPath(FlatBufferBuilder builder, StringOffset RHandPointPathOffset) { builder.AddOffset(4, RHandPointPathOffset.Value, 0); }
  public static void AddLFootPointPath(FlatBufferBuilder builder, StringOffset LFootPointPathOffset) { builder.AddOffset(5, LFootPointPathOffset.Value, 0); }
  public static void AddRFootPointPath(FlatBufferBuilder builder, StringOffset RFootPointPathOffset) { builder.AddOffset(6, RFootPointPathOffset.Value, 0); }
  public static void AddLUpperArmPointPath(FlatBufferBuilder builder, StringOffset LUpperArmPointPathOffset) { builder.AddOffset(7, LUpperArmPointPathOffset.Value, 0); }
  public static void AddWingPointPath(FlatBufferBuilder builder, StringOffset WingPointPathOffset) { builder.AddOffset(8, WingPointPathOffset.Value, 0); }
  public static void AddShenQiPointPath(FlatBufferBuilder builder, StringOffset ShenQiPointPathOffset) { builder.AddOffset(9, ShenQiPointPathOffset.Value, 0); }
  public static void AddWeaponPointPath(FlatBufferBuilder builder, StringOffset WeaponPointPathOffset) { builder.AddOffset(10, WeaponPointPathOffset.Value, 0); }
  public static Offset<FB_EffectPoint> EndFB_EffectPoint(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EffectPoint>(o);
  }
};

public sealed class FB_EffectPointContainer : Table {
  public static FB_EffectPointContainer GetRootAsFB_EffectPointContainer(ByteBuffer _bb) { return GetRootAsFB_EffectPointContainer(_bb, new FB_EffectPointContainer()); }
  public static FB_EffectPointContainer GetRootAsFB_EffectPointContainer(ByteBuffer _bb, FB_EffectPointContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EffectPointContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EffectPointContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EffectPoint GetItems(int j) { return GetItems(new FB_EffectPoint(), j); }
  public FB_EffectPoint GetItems(FB_EffectPoint obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EffectPointContainer> CreateFB_EffectPointContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EffectPointContainer.AddItems(builder, items);
    return FB_EffectPointContainer.EndFB_EffectPointContainer(builder);
  }

  public static void StartFB_EffectPointContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EffectPoint>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EffectPointContainer> EndFB_EffectPointContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EffectPointContainer>(o);
  }
  public static void FinishFB_EffectPointContainerBuffer(FlatBufferBuilder builder, Offset<FB_EffectPointContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
