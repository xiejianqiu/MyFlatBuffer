// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharXingHun : Table {
  public static FB_CharXingHun GetRootAsFB_CharXingHun(ByteBuffer _bb) { return GetRootAsFB_CharXingHun(_bb, new FB_CharXingHun()); }
  public static FB_CharXingHun GetRootAsFB_CharXingHun(ByteBuffer _bb, FB_CharXingHun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharXingHun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CharModelId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UIModel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttackAnimaId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Interval { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AppearEffectId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DisappearEffectId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float ModelOffsetY { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FlyOffsetY { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float EffectOffsetY { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float Scale { get { int o = __offset(26); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_CharXingHun> CreateFB_CharXingHun(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int CharModelId = -1,
      int UIModel = -1,
      int AttackAnimaId = -1,
      float Interval = 0,
      int AppearEffectId = 0,
      int DisappearEffectId = 0,
      float ModelOffsetY = 0,
      float FlyOffsetY = 0,
      float EffectOffsetY = 0,
      float Scale = 0) {
    builder.StartObject(12);
    FB_CharXingHun.AddScale(builder, Scale);
    FB_CharXingHun.AddEffectOffsetY(builder, EffectOffsetY);
    FB_CharXingHun.AddFlyOffsetY(builder, FlyOffsetY);
    FB_CharXingHun.AddModelOffsetY(builder, ModelOffsetY);
    FB_CharXingHun.AddDisappearEffectId(builder, DisappearEffectId);
    FB_CharXingHun.AddAppearEffectId(builder, AppearEffectId);
    FB_CharXingHun.AddInterval(builder, Interval);
    FB_CharXingHun.AddAttackAnimaId(builder, AttackAnimaId);
    FB_CharXingHun.AddUIModel(builder, UIModel);
    FB_CharXingHun.AddCharModelId(builder, CharModelId);
    FB_CharXingHun.AddName(builder, Name);
    FB_CharXingHun.AddId(builder, Id);
    return FB_CharXingHun.EndFB_CharXingHun(builder);
  }

  public static void StartFB_CharXingHun(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(2, CharModelId, -1); }
  public static void AddUIModel(FlatBufferBuilder builder, int UIModel) { builder.AddInt(3, UIModel, -1); }
  public static void AddAttackAnimaId(FlatBufferBuilder builder, int AttackAnimaId) { builder.AddInt(4, AttackAnimaId, -1); }
  public static void AddInterval(FlatBufferBuilder builder, float Interval) { builder.AddFloat(5, Interval, 0); }
  public static void AddAppearEffectId(FlatBufferBuilder builder, int AppearEffectId) { builder.AddInt(6, AppearEffectId, 0); }
  public static void AddDisappearEffectId(FlatBufferBuilder builder, int DisappearEffectId) { builder.AddInt(7, DisappearEffectId, 0); }
  public static void AddModelOffsetY(FlatBufferBuilder builder, float ModelOffsetY) { builder.AddFloat(8, ModelOffsetY, 0); }
  public static void AddFlyOffsetY(FlatBufferBuilder builder, float FlyOffsetY) { builder.AddFloat(9, FlyOffsetY, 0); }
  public static void AddEffectOffsetY(FlatBufferBuilder builder, float EffectOffsetY) { builder.AddFloat(10, EffectOffsetY, 0); }
  public static void AddScale(FlatBufferBuilder builder, float Scale) { builder.AddFloat(11, Scale, 0); }
  public static Offset<FB_CharXingHun> EndFB_CharXingHun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharXingHun>(o);
  }
};

public sealed class FB_CharXingHunContainer : Table {
  public static FB_CharXingHunContainer GetRootAsFB_CharXingHunContainer(ByteBuffer _bb) { return GetRootAsFB_CharXingHunContainer(_bb, new FB_CharXingHunContainer()); }
  public static FB_CharXingHunContainer GetRootAsFB_CharXingHunContainer(ByteBuffer _bb, FB_CharXingHunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharXingHunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharXingHunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharXingHun GetItems(int j) { return GetItems(new FB_CharXingHun(), j); }
  public FB_CharXingHun GetItems(FB_CharXingHun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharXingHunContainer> CreateFB_CharXingHunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharXingHunContainer.AddItems(builder, items);
    return FB_CharXingHunContainer.EndFB_CharXingHunContainer(builder);
  }

  public static void StartFB_CharXingHunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharXingHun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharXingHunContainer> EndFB_CharXingHunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharXingHunContainer>(o);
  }
  public static void FinishFB_CharXingHunContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharXingHunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
