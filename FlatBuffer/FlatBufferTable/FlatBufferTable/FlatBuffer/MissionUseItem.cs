// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionUseItem : Table {
  public static FB_MissionUseItem GetRootAsFB_MissionUseItem(ByteBuffer _bb) { return GetRootAsFB_MissionUseItem(_bb, new FB_MissionUseItem()); }
  public static FB_MissionUseItem GetRootAsFB_MissionUseItem(ByteBuffer _bb, FB_MissionUseItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionUseItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RoleID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionUseItem> CreateFB_MissionUseItem(FlatBufferBuilder builder,
      int Id = 0,
      int ItemID = -1,
      int RoleID = -1) {
    builder.StartObject(3);
    FB_MissionUseItem.AddRoleID(builder, RoleID);
    FB_MissionUseItem.AddItemID(builder, ItemID);
    FB_MissionUseItem.AddId(builder, Id);
    return FB_MissionUseItem.EndFB_MissionUseItem(builder);
  }

  public static void StartFB_MissionUseItem(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(1, ItemID, -1); }
  public static void AddRoleID(FlatBufferBuilder builder, int RoleID) { builder.AddInt(2, RoleID, -1); }
  public static Offset<FB_MissionUseItem> EndFB_MissionUseItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionUseItem>(o);
  }
};

public sealed class FB_MissionUseItemContainer : Table {
  public static FB_MissionUseItemContainer GetRootAsFB_MissionUseItemContainer(ByteBuffer _bb) { return GetRootAsFB_MissionUseItemContainer(_bb, new FB_MissionUseItemContainer()); }
  public static FB_MissionUseItemContainer GetRootAsFB_MissionUseItemContainer(ByteBuffer _bb, FB_MissionUseItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionUseItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionUseItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionUseItem GetItems(int j) { return GetItems(new FB_MissionUseItem(), j); }
  public FB_MissionUseItem GetItems(FB_MissionUseItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionUseItemContainer> CreateFB_MissionUseItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionUseItemContainer.AddItems(builder, items);
    return FB_MissionUseItemContainer.EndFB_MissionUseItemContainer(builder);
  }

  public static void StartFB_MissionUseItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionUseItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionUseItemContainer> EndFB_MissionUseItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionUseItemContainer>(o);
  }
  public static void FinishFB_MissionUseItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionUseItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
