// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipCompoundTypeShenZhuang : Table {
  public static FB_EquipCompoundTypeShenZhuang GetRootAsFB_EquipCompoundTypeShenZhuang(ByteBuffer _bb) { return GetRootAsFB_EquipCompoundTypeShenZhuang(_bb, new FB_EquipCompoundTypeShenZhuang()); }
  public static FB_EquipCompoundTypeShenZhuang GetRootAsFB_EquipCompoundTypeShenZhuang(ByteBuffer _bb, FB_EquipCompoundTypeShenZhuang obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipCompoundTypeShenZhuang __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FirstPage { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SecondPage { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StarNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MenPai { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string EquipPoint { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ExtraMaterial { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Type { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EquipGrade { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipCompoundTypeShenZhuang> CreateFB_EquipCompoundTypeShenZhuang(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int FirstPage = -1,
      int SecondPage = -1,
      int Quality = -1,
      int StarNum = -1,
      int MenPai = -1,
      StringOffset EquipPoint = default(StringOffset),
      int ExtraMaterial = -1,
      int Type = -1,
      int EquipGrade = -1) {
    builder.StartObject(11);
    FB_EquipCompoundTypeShenZhuang.AddEquipGrade(builder, EquipGrade);
    FB_EquipCompoundTypeShenZhuang.AddType(builder, Type);
    FB_EquipCompoundTypeShenZhuang.AddExtraMaterial(builder, ExtraMaterial);
    FB_EquipCompoundTypeShenZhuang.AddEquipPoint(builder, EquipPoint);
    FB_EquipCompoundTypeShenZhuang.AddMenPai(builder, MenPai);
    FB_EquipCompoundTypeShenZhuang.AddStarNum(builder, StarNum);
    FB_EquipCompoundTypeShenZhuang.AddQuality(builder, Quality);
    FB_EquipCompoundTypeShenZhuang.AddSecondPage(builder, SecondPage);
    FB_EquipCompoundTypeShenZhuang.AddFirstPage(builder, FirstPage);
    FB_EquipCompoundTypeShenZhuang.AddName(builder, Name);
    FB_EquipCompoundTypeShenZhuang.AddID(builder, ID);
    return FB_EquipCompoundTypeShenZhuang.EndFB_EquipCompoundTypeShenZhuang(builder);
  }

  public static void StartFB_EquipCompoundTypeShenZhuang(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddFirstPage(FlatBufferBuilder builder, int FirstPage) { builder.AddInt(2, FirstPage, -1); }
  public static void AddSecondPage(FlatBufferBuilder builder, int SecondPage) { builder.AddInt(3, SecondPage, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, -1); }
  public static void AddStarNum(FlatBufferBuilder builder, int StarNum) { builder.AddInt(5, StarNum, -1); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(6, MenPai, -1); }
  public static void AddEquipPoint(FlatBufferBuilder builder, StringOffset EquipPointOffset) { builder.AddOffset(7, EquipPointOffset.Value, 0); }
  public static void AddExtraMaterial(FlatBufferBuilder builder, int ExtraMaterial) { builder.AddInt(8, ExtraMaterial, -1); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(9, Type, -1); }
  public static void AddEquipGrade(FlatBufferBuilder builder, int EquipGrade) { builder.AddInt(10, EquipGrade, -1); }
  public static Offset<FB_EquipCompoundTypeShenZhuang> EndFB_EquipCompoundTypeShenZhuang(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipCompoundTypeShenZhuang>(o);
  }
};

public sealed class FB_EquipCompoundTypeShenZhuangContainer : Table {
  public static FB_EquipCompoundTypeShenZhuangContainer GetRootAsFB_EquipCompoundTypeShenZhuangContainer(ByteBuffer _bb) { return GetRootAsFB_EquipCompoundTypeShenZhuangContainer(_bb, new FB_EquipCompoundTypeShenZhuangContainer()); }
  public static FB_EquipCompoundTypeShenZhuangContainer GetRootAsFB_EquipCompoundTypeShenZhuangContainer(ByteBuffer _bb, FB_EquipCompoundTypeShenZhuangContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipCompoundTypeShenZhuangContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipCompoundTypeShenZhuangContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipCompoundTypeShenZhuang GetItems(int j) { return GetItems(new FB_EquipCompoundTypeShenZhuang(), j); }
  public FB_EquipCompoundTypeShenZhuang GetItems(FB_EquipCompoundTypeShenZhuang obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipCompoundTypeShenZhuangContainer> CreateFB_EquipCompoundTypeShenZhuangContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipCompoundTypeShenZhuangContainer.AddItems(builder, items);
    return FB_EquipCompoundTypeShenZhuangContainer.EndFB_EquipCompoundTypeShenZhuangContainer(builder);
  }

  public static void StartFB_EquipCompoundTypeShenZhuangContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipCompoundTypeShenZhuang>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipCompoundTypeShenZhuangContainer> EndFB_EquipCompoundTypeShenZhuangContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipCompoundTypeShenZhuangContainer>(o);
  }
  public static void FinishFB_EquipCompoundTypeShenZhuangContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipCompoundTypeShenZhuangContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
