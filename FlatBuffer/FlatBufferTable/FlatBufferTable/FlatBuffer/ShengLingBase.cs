// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingBase : Table {
  public static FB_ShengLingBase GetRootAsFB_ShengLingBase(ByteBuffer _bb) { return GetRootAsFB_ShengLingBase(_bb, new FB_ShengLingBase()); }
  public static FB_ShengLingBase GetRootAsFB_ShengLingBase(ByteBuffer _bb, FB_ShengLingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockLevel { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSpecialLevelList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpecialLevelListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingBase> CreateFB_ShengLingBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int UnlockLevel = -1,
      int ItemId = -1,
      int ItemCount = -1,
      VectorOffset SpecialLevelList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_ShengLingBase.AddSpecialLevelList(builder, SpecialLevelList);
    FB_ShengLingBase.AddItemCount(builder, ItemCount);
    FB_ShengLingBase.AddItemId(builder, ItemId);
    FB_ShengLingBase.AddUnlockLevel(builder, UnlockLevel);
    FB_ShengLingBase.AddIcon(builder, Icon);
    FB_ShengLingBase.AddName(builder, Name);
    FB_ShengLingBase.AddId(builder, Id);
    return FB_ShengLingBase.EndFB_ShengLingBase(builder);
  }

  public static void StartFB_ShengLingBase(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddUnlockLevel(FlatBufferBuilder builder, int UnlockLevel) { builder.AddInt(3, UnlockLevel, -1); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(4, ItemId, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(5, ItemCount, -1); }
  public static void AddSpecialLevelList(FlatBufferBuilder builder, VectorOffset SpecialLevelListOffset) { builder.AddOffset(6, SpecialLevelListOffset.Value, 0); }
  public static VectorOffset CreateSpecialLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpecialLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingBase> EndFB_ShengLingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingBase>(o);
  }
};

public sealed class FB_ShengLingBaseContainer : Table {
  public static FB_ShengLingBaseContainer GetRootAsFB_ShengLingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingBaseContainer(_bb, new FB_ShengLingBaseContainer()); }
  public static FB_ShengLingBaseContainer GetRootAsFB_ShengLingBaseContainer(ByteBuffer _bb, FB_ShengLingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingBase GetItems(int j) { return GetItems(new FB_ShengLingBase(), j); }
  public FB_ShengLingBase GetItems(FB_ShengLingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingBaseContainer> CreateFB_ShengLingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingBaseContainer.AddItems(builder, items);
    return FB_ShengLingBaseContainer.EndFB_ShengLingBaseContainer(builder);
  }

  public static void StartFB_ShengLingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingBaseContainer> EndFB_ShengLingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingBaseContainer>(o);
  }
  public static void FinishFB_ShengLingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
