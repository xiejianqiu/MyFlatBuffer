// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MaiDianSuit : Table {
  public static FB_MaiDianSuit GetRootAsFB_MaiDianSuit(ByteBuffer _bb) { return GetRootAsFB_MaiDianSuit(_bb, new FB_MaiDianSuit()); }
  public static FB_MaiDianSuit GetRootAsFB_MaiDianSuit(ByteBuffer _bb, FB_MaiDianSuit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MaiDianSuit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int System { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Switch { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Conditon { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Nameicon { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetItemList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSkillList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string Photo { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public float PositionX { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float PositionY { get { int o = __offset(24); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int Model { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Button { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Wear { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string NameiconSelect { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockDescStrId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetNewModelId { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenServerDay { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsLevelHundred { get { int o = __offset(40); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_MaiDianSuit> CreateFB_MaiDianSuit(FlatBufferBuilder builder,
      int ID = 0,
      int System = -1,
      int Switch = -1,
      int Conditon = -1,
      StringOffset Name = default(StringOffset),
      StringOffset Nameicon = default(StringOffset),
      VectorOffset ItemList = default(VectorOffset),
      VectorOffset SkillList = default(VectorOffset),
      StringOffset Photo = default(StringOffset),
      float PositionX = -1,
      float PositionY = -1,
      int Model = -1,
      int Button = -1,
      int Wear = -1,
      StringOffset NameiconSelect = default(StringOffset),
      int unlockDescStrId = -1,
      int GetNewModelId = -1,
      int OpenServerDay = 0,
      bool IsLevelHundred = false) {
    builder.StartObject(19);
    FB_MaiDianSuit.AddOpenServerDay(builder, OpenServerDay);
    FB_MaiDianSuit.AddGetNewModelId(builder, GetNewModelId);
    FB_MaiDianSuit.AddUnlockDescStrId(builder, unlockDescStrId);
    FB_MaiDianSuit.AddNameiconSelect(builder, NameiconSelect);
    FB_MaiDianSuit.AddWear(builder, Wear);
    FB_MaiDianSuit.AddButton(builder, Button);
    FB_MaiDianSuit.AddModel(builder, Model);
    FB_MaiDianSuit.AddPositionY(builder, PositionY);
    FB_MaiDianSuit.AddPositionX(builder, PositionX);
    FB_MaiDianSuit.AddPhoto(builder, Photo);
    FB_MaiDianSuit.AddSkillList(builder, SkillList);
    FB_MaiDianSuit.AddItemList(builder, ItemList);
    FB_MaiDianSuit.AddNameicon(builder, Nameicon);
    FB_MaiDianSuit.AddName(builder, Name);
    FB_MaiDianSuit.AddConditon(builder, Conditon);
    FB_MaiDianSuit.AddSwitch(builder, Switch);
    FB_MaiDianSuit.AddSystem(builder, System);
    FB_MaiDianSuit.AddID(builder, ID);
    FB_MaiDianSuit.AddIsLevelHundred(builder, IsLevelHundred);
    return FB_MaiDianSuit.EndFB_MaiDianSuit(builder);
  }

  public static void StartFB_MaiDianSuit(FlatBufferBuilder builder) { builder.StartObject(19); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddSystem(FlatBufferBuilder builder, int System) { builder.AddInt(1, System, -1); }
  public static void AddSwitch(FlatBufferBuilder builder, int Switch) { builder.AddInt(2, Switch, -1); }
  public static void AddConditon(FlatBufferBuilder builder, int Conditon) { builder.AddInt(3, Conditon, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(4, NameOffset.Value, 0); }
  public static void AddNameicon(FlatBufferBuilder builder, StringOffset NameiconOffset) { builder.AddOffset(5, NameiconOffset.Value, 0); }
  public static void AddItemList(FlatBufferBuilder builder, VectorOffset ItemListOffset) { builder.AddOffset(6, ItemListOffset.Value, 0); }
  public static VectorOffset CreateItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillList(FlatBufferBuilder builder, VectorOffset SkillListOffset) { builder.AddOffset(7, SkillListOffset.Value, 0); }
  public static VectorOffset CreateSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPhoto(FlatBufferBuilder builder, StringOffset PhotoOffset) { builder.AddOffset(8, PhotoOffset.Value, 0); }
  public static void AddPositionX(FlatBufferBuilder builder, float PositionX) { builder.AddFloat(9, PositionX, -1); }
  public static void AddPositionY(FlatBufferBuilder builder, float PositionY) { builder.AddFloat(10, PositionY, -1); }
  public static void AddModel(FlatBufferBuilder builder, int Model) { builder.AddInt(11, Model, -1); }
  public static void AddButton(FlatBufferBuilder builder, int Button) { builder.AddInt(12, Button, -1); }
  public static void AddWear(FlatBufferBuilder builder, int Wear) { builder.AddInt(13, Wear, -1); }
  public static void AddNameiconSelect(FlatBufferBuilder builder, StringOffset NameiconSelectOffset) { builder.AddOffset(14, NameiconSelectOffset.Value, 0); }
  public static void AddUnlockDescStrId(FlatBufferBuilder builder, int unlockDescStrId) { builder.AddInt(15, unlockDescStrId, -1); }
  public static void AddGetNewModelId(FlatBufferBuilder builder, int GetNewModelId) { builder.AddInt(16, GetNewModelId, -1); }
  public static void AddOpenServerDay(FlatBufferBuilder builder, int OpenServerDay) { builder.AddInt(17, OpenServerDay, 0); }
  public static void AddIsLevelHundred(FlatBufferBuilder builder, bool IsLevelHundred) { builder.AddBool(18, IsLevelHundred, false); }
  public static Offset<FB_MaiDianSuit> EndFB_MaiDianSuit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianSuit>(o);
  }
};

public sealed class FB_MaiDianSuitContainer : Table {
  public static FB_MaiDianSuitContainer GetRootAsFB_MaiDianSuitContainer(ByteBuffer _bb) { return GetRootAsFB_MaiDianSuitContainer(_bb, new FB_MaiDianSuitContainer()); }
  public static FB_MaiDianSuitContainer GetRootAsFB_MaiDianSuitContainer(ByteBuffer _bb, FB_MaiDianSuitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MaiDianSuitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MaiDianSuitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MaiDianSuit GetItems(int j) { return GetItems(new FB_MaiDianSuit(), j); }
  public FB_MaiDianSuit GetItems(FB_MaiDianSuit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MaiDianSuitContainer> CreateFB_MaiDianSuitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MaiDianSuitContainer.AddItems(builder, items);
    return FB_MaiDianSuitContainer.EndFB_MaiDianSuitContainer(builder);
  }

  public static void StartFB_MaiDianSuitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MaiDianSuit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MaiDianSuitContainer> EndFB_MaiDianSuitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MaiDianSuitContainer>(o);
  }
  public static void FinishFB_MaiDianSuitContainerBuffer(FlatBufferBuilder builder, Offset<FB_MaiDianSuitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
