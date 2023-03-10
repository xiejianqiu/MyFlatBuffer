// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_DestinyBloodSkillDes : Table {
  public static FB_DestinyBloodSkillDes GetRootAsFB_DestinyBloodSkillDes(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodSkillDes(_bb, new FB_DestinyBloodSkillDes()); }
  public static FB_DestinyBloodSkillDes GetRootAsFB_DestinyBloodSkillDes(ByteBuffer _bb, FB_DestinyBloodSkillDes obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_DestinyBloodSkillDes __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaxLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrDicID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float GetBasicValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int BasicValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public float GetDescParamList(int j) { int o = __offset(16); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int DescParamListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodSkillDes> CreateFB_DestinyBloodSkillDes(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int MaxLevel = 0,
      int StrDicID = -1,
      VectorOffset BasicValueList = default(VectorOffset),
      VectorOffset DescParamList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_DestinyBloodSkillDes.AddDescParamList(builder, DescParamList);
    FB_DestinyBloodSkillDes.AddBasicValueList(builder, BasicValueList);
    FB_DestinyBloodSkillDes.AddStrDicID(builder, StrDicID);
    FB_DestinyBloodSkillDes.AddMaxLevel(builder, MaxLevel);
    FB_DestinyBloodSkillDes.AddIcon(builder, Icon);
    FB_DestinyBloodSkillDes.AddName(builder, Name);
    FB_DestinyBloodSkillDes.AddId(builder, Id);
    return FB_DestinyBloodSkillDes.EndFB_DestinyBloodSkillDes(builder);
  }

  public static void StartFB_DestinyBloodSkillDes(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(3, MaxLevel, 0); }
  public static void AddStrDicID(FlatBufferBuilder builder, int StrDicID) { builder.AddInt(4, StrDicID, -1); }
  public static void AddBasicValueList(FlatBufferBuilder builder, VectorOffset BasicValueListOffset) { builder.AddOffset(5, BasicValueListOffset.Value, 0); }
  public static VectorOffset CreateBasicValueListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartBasicValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(6, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBloodSkillDes> EndFB_DestinyBloodSkillDes(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodSkillDes>(o);
  }
};

public sealed class FB_DestinyBloodSkillDesContainer : Table {
  public static FB_DestinyBloodSkillDesContainer GetRootAsFB_DestinyBloodSkillDesContainer(ByteBuffer _bb) { return GetRootAsFB_DestinyBloodSkillDesContainer(_bb, new FB_DestinyBloodSkillDesContainer()); }
  public static FB_DestinyBloodSkillDesContainer GetRootAsFB_DestinyBloodSkillDesContainer(ByteBuffer _bb, FB_DestinyBloodSkillDesContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_DestinyBloodSkillDesContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_DestinyBloodSkillDesContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_DestinyBloodSkillDes GetItems(int j) { return GetItems(new FB_DestinyBloodSkillDes(), j); }
  public FB_DestinyBloodSkillDes GetItems(FB_DestinyBloodSkillDes obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_DestinyBloodSkillDesContainer> CreateFB_DestinyBloodSkillDesContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_DestinyBloodSkillDesContainer.AddItems(builder, items);
    return FB_DestinyBloodSkillDesContainer.EndFB_DestinyBloodSkillDesContainer(builder);
  }

  public static void StartFB_DestinyBloodSkillDesContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_DestinyBloodSkillDes>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_DestinyBloodSkillDesContainer> EndFB_DestinyBloodSkillDesContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_DestinyBloodSkillDesContainer>(o);
  }
  public static void FinishFB_DestinyBloodSkillDesContainerBuffer(FlatBufferBuilder builder, Offset<FB_DestinyBloodSkillDesContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
