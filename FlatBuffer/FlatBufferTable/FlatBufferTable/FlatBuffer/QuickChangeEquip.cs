// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_QuickChangeEquip : Table {
  public static FB_QuickChangeEquip GetRootAsFB_QuickChangeEquip(ByteBuffer _bb) { return GetRootAsFB_QuickChangeEquip(_bb, new FB_QuickChangeEquip()); }
  public static FB_QuickChangeEquip GetRootAsFB_QuickChangeEquip(ByteBuffer _bb, FB_QuickChangeEquip obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_QuickChangeEquip __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockParamList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockParamListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_QuickChangeEquip> CreateFB_QuickChangeEquip(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      int UnLockType = -1,
      VectorOffset UnLockParamList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_QuickChangeEquip.AddUnLockParamList(builder, UnLockParamList);
    FB_QuickChangeEquip.AddUnLockType(builder, UnLockType);
    FB_QuickChangeEquip.AddType(builder, Type);
    FB_QuickChangeEquip.AddName(builder, Name);
    FB_QuickChangeEquip.AddID(builder, ID);
    return FB_QuickChangeEquip.EndFB_QuickChangeEquip(builder);
  }

  public static void StartFB_QuickChangeEquip(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, -1); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(3, UnLockType, -1); }
  public static void AddUnLockParamList(FlatBufferBuilder builder, VectorOffset UnLockParamListOffset) { builder.AddOffset(4, UnLockParamListOffset.Value, 0); }
  public static VectorOffset CreateUnLockParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_QuickChangeEquip> EndFB_QuickChangeEquip(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QuickChangeEquip>(o);
  }
};

public sealed class FB_QuickChangeEquipContainer : Table {
  public static FB_QuickChangeEquipContainer GetRootAsFB_QuickChangeEquipContainer(ByteBuffer _bb) { return GetRootAsFB_QuickChangeEquipContainer(_bb, new FB_QuickChangeEquipContainer()); }
  public static FB_QuickChangeEquipContainer GetRootAsFB_QuickChangeEquipContainer(ByteBuffer _bb, FB_QuickChangeEquipContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_QuickChangeEquipContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_QuickChangeEquipContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_QuickChangeEquip GetItems(int j) { return GetItems(new FB_QuickChangeEquip(), j); }
  public FB_QuickChangeEquip GetItems(FB_QuickChangeEquip obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_QuickChangeEquipContainer> CreateFB_QuickChangeEquipContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_QuickChangeEquipContainer.AddItems(builder, items);
    return FB_QuickChangeEquipContainer.EndFB_QuickChangeEquipContainer(builder);
  }

  public static void StartFB_QuickChangeEquipContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_QuickChangeEquip>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_QuickChangeEquipContainer> EndFB_QuickChangeEquipContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_QuickChangeEquipContainer>(o);
  }
  public static void FinishFB_QuickChangeEquipContainerBuffer(FlatBufferBuilder builder, Offset<FB_QuickChangeEquipContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
