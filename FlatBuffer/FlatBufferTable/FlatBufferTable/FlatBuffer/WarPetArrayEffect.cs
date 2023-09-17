// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_WarPetArrayEffect : Table {
  public static FB_WarPetArrayEffect GetRootAsFB_WarPetArrayEffect(ByteBuffer _bb) { return GetRootAsFB_WarPetArrayEffect(_bb, new FB_WarPetArrayEffect()); }
  public static FB_WarPetArrayEffect GetRootAsFB_WarPetArrayEffect(ByteBuffer _bb, FB_WarPetArrayEffect obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_WarPetArrayEffect __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetPassiveSkillList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetArrayEffect> CreateFB_WarPetArrayEffect(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset PassiveSkillList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_WarPetArrayEffect.AddPassiveSkillList(builder, PassiveSkillList);
    FB_WarPetArrayEffect.AddName(builder, Name);
    FB_WarPetArrayEffect.AddId(builder, Id);
    return FB_WarPetArrayEffect.EndFB_WarPetArrayEffect(builder);
  }

  public static void StartFB_WarPetArrayEffect(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(2, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetArrayEffect> EndFB_WarPetArrayEffect(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetArrayEffect>(o);
  }
};

public sealed class FB_WarPetArrayEffectContainer : Table {
  public static FB_WarPetArrayEffectContainer GetRootAsFB_WarPetArrayEffectContainer(ByteBuffer _bb) { return GetRootAsFB_WarPetArrayEffectContainer(_bb, new FB_WarPetArrayEffectContainer()); }
  public static FB_WarPetArrayEffectContainer GetRootAsFB_WarPetArrayEffectContainer(ByteBuffer _bb, FB_WarPetArrayEffectContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_WarPetArrayEffectContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_WarPetArrayEffectContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_WarPetArrayEffect GetItems(int j) { return GetItems(new FB_WarPetArrayEffect(), j); }
  public FB_WarPetArrayEffect GetItems(FB_WarPetArrayEffect obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_WarPetArrayEffectContainer> CreateFB_WarPetArrayEffectContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_WarPetArrayEffectContainer.AddItems(builder, items);
    return FB_WarPetArrayEffectContainer.EndFB_WarPetArrayEffectContainer(builder);
  }

  public static void StartFB_WarPetArrayEffectContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_WarPetArrayEffect>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_WarPetArrayEffectContainer> EndFB_WarPetArrayEffectContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_WarPetArrayEffectContainer>(o);
  }
  public static void FinishFB_WarPetArrayEffectContainerBuffer(FlatBufferBuilder builder, Offset<FB_WarPetArrayEffectContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
