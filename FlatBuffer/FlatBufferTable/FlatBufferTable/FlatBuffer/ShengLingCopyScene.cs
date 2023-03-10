// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShengLingCopyScene : Table {
  public static FB_ShengLingCopyScene GetRootAsFB_ShengLingCopyScene(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopyScene(_bb, new FB_ShengLingCopyScene()); }
  public static FB_ShengLingCopyScene GetRootAsFB_ShengLingCopyScene(ByteBuffer _bb, FB_ShengLingCopyScene obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShengLingCopyScene __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RoleBaseAttrId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockLevel { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int DropBox { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ShengLingCopyScene> CreateFB_ShengLingCopyScene(FlatBufferBuilder builder,
      int Id = 0,
      int RoleBaseAttrId = -1,
      StringOffset Name = default(StringOffset),
      int Type = -1,
      int UnLockLevel = -1,
      VectorOffset ItemList = default(VectorOffset),
      int DropBox = -1) {
    builder.StartObject(7);
    FB_ShengLingCopyScene.AddDropBox(builder, DropBox);
    FB_ShengLingCopyScene.AddItemList(builder, ItemList);
    FB_ShengLingCopyScene.AddUnLockLevel(builder, UnLockLevel);
    FB_ShengLingCopyScene.AddType(builder, Type);
    FB_ShengLingCopyScene.AddName(builder, Name);
    FB_ShengLingCopyScene.AddRoleBaseAttrId(builder, RoleBaseAttrId);
    FB_ShengLingCopyScene.AddId(builder, Id);
    return FB_ShengLingCopyScene.EndFB_ShengLingCopyScene(builder);
  }

  public static void StartFB_ShengLingCopyScene(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRoleBaseAttrId(FlatBufferBuilder builder, int RoleBaseAttrId) { builder.AddInt(1, RoleBaseAttrId, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(3, Type, -1); }
  public static void AddUnLockLevel(FlatBufferBuilder builder, int UnLockLevel) { builder.AddInt(4, UnLockLevel, -1); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(5, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropBox(FlatBufferBuilder builder, int DropBox) { builder.AddInt(6, DropBox, -1); }
  public static Offset<FB_ShengLingCopyScene> EndFB_ShengLingCopyScene(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopyScene>(o);
  }
};

public sealed class FB_ShengLingCopySceneContainer : Table {
  public static FB_ShengLingCopySceneContainer GetRootAsFB_ShengLingCopySceneContainer(ByteBuffer _bb) { return GetRootAsFB_ShengLingCopySceneContainer(_bb, new FB_ShengLingCopySceneContainer()); }
  public static FB_ShengLingCopySceneContainer GetRootAsFB_ShengLingCopySceneContainer(ByteBuffer _bb, FB_ShengLingCopySceneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShengLingCopySceneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShengLingCopySceneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShengLingCopyScene GetItems(int j) { return GetItems(new FB_ShengLingCopyScene(), j); }
  public FB_ShengLingCopyScene GetItems(FB_ShengLingCopyScene obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShengLingCopySceneContainer> CreateFB_ShengLingCopySceneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShengLingCopySceneContainer.AddItems(builder, items);
    return FB_ShengLingCopySceneContainer.EndFB_ShengLingCopySceneContainer(builder);
  }

  public static void StartFB_ShengLingCopySceneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShengLingCopyScene>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShengLingCopySceneContainer> EndFB_ShengLingCopySceneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShengLingCopySceneContainer>(o);
  }
  public static void FinishFB_ShengLingCopySceneContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShengLingCopySceneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
