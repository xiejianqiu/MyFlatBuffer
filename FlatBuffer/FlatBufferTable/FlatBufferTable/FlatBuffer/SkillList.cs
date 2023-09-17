// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillList : Table {
  public static FB_SkillList GetRootAsFB_SkillList(ByteBuffer _bb) { return GetRootAsFB_SkillList(_bb, new FB_SkillList()); }
  public static FB_SkillList GetRootAsFB_SkillList(ByteBuffer _bb, FB_SkillList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PassiveSkillID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetPathName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Introduce { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PathItemName { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsAddMenPai { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_SkillList> CreateFB_SkillList(FlatBufferBuilder builder,
      int Id = 0,
      int PassiveSkillID = -1,
      StringOffset GetPathName = default(StringOffset),
      StringOffset Introduce = default(StringOffset),
      StringOffset PathItemName = default(StringOffset),
      bool IsAddMenPai = false) {
    builder.StartObject(6);
    FB_SkillList.AddPathItemName(builder, PathItemName);
    FB_SkillList.AddIntroduce(builder, Introduce);
    FB_SkillList.AddGetPathName(builder, GetPathName);
    FB_SkillList.AddPassiveSkillID(builder, PassiveSkillID);
    FB_SkillList.AddId(builder, Id);
    FB_SkillList.AddIsAddMenPai(builder, IsAddMenPai);
    return FB_SkillList.EndFB_SkillList(builder);
  }

  public static void StartFB_SkillList(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPassiveSkillID(FlatBufferBuilder builder, int PassiveSkillID) { builder.AddInt(1, PassiveSkillID, -1); }
  public static void AddGetPathName(FlatBufferBuilder builder, StringOffset GetPathNameOffset) { builder.AddOffset(2, GetPathNameOffset.Value, 0); }
  public static void AddIntroduce(FlatBufferBuilder builder, StringOffset IntroduceOffset) { builder.AddOffset(3, IntroduceOffset.Value, 0); }
  public static void AddPathItemName(FlatBufferBuilder builder, StringOffset PathItemNameOffset) { builder.AddOffset(4, PathItemNameOffset.Value, 0); }
  public static void AddIsAddMenPai(FlatBufferBuilder builder, bool IsAddMenPai) { builder.AddBool(5, IsAddMenPai, false); }
  public static Offset<FB_SkillList> EndFB_SkillList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillList>(o);
  }
};

public sealed class FB_SkillListContainer : Table {
  public static FB_SkillListContainer GetRootAsFB_SkillListContainer(ByteBuffer _bb) { return GetRootAsFB_SkillListContainer(_bb, new FB_SkillListContainer()); }
  public static FB_SkillListContainer GetRootAsFB_SkillListContainer(ByteBuffer _bb, FB_SkillListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillList GetItems(int j) { return GetItems(new FB_SkillList(), j); }
  public FB_SkillList GetItems(FB_SkillList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillListContainer> CreateFB_SkillListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillListContainer.AddItems(builder, items);
    return FB_SkillListContainer.EndFB_SkillListContainer(builder);
  }

  public static void StartFB_SkillListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillListContainer> EndFB_SkillListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillListContainer>(o);
  }
  public static void FinishFB_SkillListContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
