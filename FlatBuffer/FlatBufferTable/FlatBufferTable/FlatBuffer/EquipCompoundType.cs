// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipCompoundType : Table {
  public static FB_EquipCompoundType GetRootAsFB_EquipCompoundType(ByteBuffer _bb) { return GetRootAsFB_EquipCompoundType(_bb, new FB_EquipCompoundType()); }
  public static FB_EquipCompoundType GetRootAsFB_EquipCompoundType(ByteBuffer _bb, FB_EquipCompoundType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipCompoundType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FirstPage { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SecondPage { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StarNum { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MenPai { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string EquipPoint { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ExtraMaterial { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipCompoundType> CreateFB_EquipCompoundType(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int FirstPage = -1,
      int SecondPage = -1,
      int Quality = -1,
      int StarNum = -1,
      int MenPai = -1,
      StringOffset EquipPoint = default(StringOffset),
      int ExtraMaterial = -1) {
    builder.StartObject(9);
    FB_EquipCompoundType.AddExtraMaterial(builder, ExtraMaterial);
    FB_EquipCompoundType.AddEquipPoint(builder, EquipPoint);
    FB_EquipCompoundType.AddMenPai(builder, MenPai);
    FB_EquipCompoundType.AddStarNum(builder, StarNum);
    FB_EquipCompoundType.AddQuality(builder, Quality);
    FB_EquipCompoundType.AddSecondPage(builder, SecondPage);
    FB_EquipCompoundType.AddFirstPage(builder, FirstPage);
    FB_EquipCompoundType.AddName(builder, Name);
    FB_EquipCompoundType.AddID(builder, ID);
    return FB_EquipCompoundType.EndFB_EquipCompoundType(builder);
  }

  public static void StartFB_EquipCompoundType(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddFirstPage(FlatBufferBuilder builder, int FirstPage) { builder.AddInt(2, FirstPage, -1); }
  public static void AddSecondPage(FlatBufferBuilder builder, int SecondPage) { builder.AddInt(3, SecondPage, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, -1); }
  public static void AddStarNum(FlatBufferBuilder builder, int StarNum) { builder.AddInt(5, StarNum, -1); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(6, MenPai, -1); }
  public static void AddEquipPoint(FlatBufferBuilder builder, StringOffset EquipPointOffset) { builder.AddOffset(7, EquipPointOffset.Value, 0); }
  public static void AddExtraMaterial(FlatBufferBuilder builder, int ExtraMaterial) { builder.AddInt(8, ExtraMaterial, -1); }
  public static Offset<FB_EquipCompoundType> EndFB_EquipCompoundType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipCompoundType>(o);
  }
};

public sealed class FB_EquipCompoundTypeContainer : Table {
  public static FB_EquipCompoundTypeContainer GetRootAsFB_EquipCompoundTypeContainer(ByteBuffer _bb) { return GetRootAsFB_EquipCompoundTypeContainer(_bb, new FB_EquipCompoundTypeContainer()); }
  public static FB_EquipCompoundTypeContainer GetRootAsFB_EquipCompoundTypeContainer(ByteBuffer _bb, FB_EquipCompoundTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipCompoundTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipCompoundTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipCompoundType GetItems(int j) { return GetItems(new FB_EquipCompoundType(), j); }
  public FB_EquipCompoundType GetItems(FB_EquipCompoundType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipCompoundTypeContainer> CreateFB_EquipCompoundTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipCompoundTypeContainer.AddItems(builder, items);
    return FB_EquipCompoundTypeContainer.EndFB_EquipCompoundTypeContainer(builder);
  }

  public static void StartFB_EquipCompoundTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipCompoundType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipCompoundTypeContainer> EndFB_EquipCompoundTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipCompoundTypeContainer>(o);
  }
  public static void FinishFB_EquipCompoundTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipCompoundTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
