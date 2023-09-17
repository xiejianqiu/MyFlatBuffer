// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CharSoul : Table {
  public static FB_CharSoul GetRootAsFB_CharSoul(ByteBuffer _bb) { return GetRootAsFB_CharSoul(_bb, new FB_CharSoul()); }
  public static FB_CharSoul GetRootAsFB_CharSoul(ByteBuffer _bb, FB_CharSoul obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CharSoul __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int CharModelId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AttackAnimaId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float Interval { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int AppearEffectId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DisappearEffectId { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UIModel { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PaoPaoHeight { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_CharSoul> CreateFB_CharSoul(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int CharModelId = -1,
      int AttackAnimaId = -1,
      float Interval = 0,
      int AppearEffectId = 0,
      int DisappearEffectId = 0,
      int UIModel = -1,
      float PaoPaoHeight = 0) {
    builder.StartObject(9);
    FB_CharSoul.AddPaoPaoHeight(builder, PaoPaoHeight);
    FB_CharSoul.AddUIModel(builder, UIModel);
    FB_CharSoul.AddDisappearEffectId(builder, DisappearEffectId);
    FB_CharSoul.AddAppearEffectId(builder, AppearEffectId);
    FB_CharSoul.AddInterval(builder, Interval);
    FB_CharSoul.AddAttackAnimaId(builder, AttackAnimaId);
    FB_CharSoul.AddCharModelId(builder, CharModelId);
    FB_CharSoul.AddName(builder, Name);
    FB_CharSoul.AddId(builder, Id);
    return FB_CharSoul.EndFB_CharSoul(builder);
  }

  public static void StartFB_CharSoul(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(2, CharModelId, -1); }
  public static void AddAttackAnimaId(FlatBufferBuilder builder, int AttackAnimaId) { builder.AddInt(3, AttackAnimaId, -1); }
  public static void AddInterval(FlatBufferBuilder builder, float Interval) { builder.AddFloat(4, Interval, 0); }
  public static void AddAppearEffectId(FlatBufferBuilder builder, int AppearEffectId) { builder.AddInt(5, AppearEffectId, 0); }
  public static void AddDisappearEffectId(FlatBufferBuilder builder, int DisappearEffectId) { builder.AddInt(6, DisappearEffectId, 0); }
  public static void AddUIModel(FlatBufferBuilder builder, int UIModel) { builder.AddInt(7, UIModel, -1); }
  public static void AddPaoPaoHeight(FlatBufferBuilder builder, float PaoPaoHeight) { builder.AddFloat(8, PaoPaoHeight, 0); }
  public static Offset<FB_CharSoul> EndFB_CharSoul(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharSoul>(o);
  }
};

public sealed class FB_CharSoulContainer : Table {
  public static FB_CharSoulContainer GetRootAsFB_CharSoulContainer(ByteBuffer _bb) { return GetRootAsFB_CharSoulContainer(_bb, new FB_CharSoulContainer()); }
  public static FB_CharSoulContainer GetRootAsFB_CharSoulContainer(ByteBuffer _bb, FB_CharSoulContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CharSoulContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CharSoulContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CharSoul GetItems(int j) { return GetItems(new FB_CharSoul(), j); }
  public FB_CharSoul GetItems(FB_CharSoul obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CharSoulContainer> CreateFB_CharSoulContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CharSoulContainer.AddItems(builder, items);
    return FB_CharSoulContainer.EndFB_CharSoulContainer(builder);
  }

  public static void StartFB_CharSoulContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CharSoul>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CharSoulContainer> EndFB_CharSoulContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CharSoulContainer>(o);
  }
  public static void FinishFB_CharSoulContainerBuffer(FlatBufferBuilder builder, Offset<FB_CharSoulContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
