// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionBonus : Table {
  public static FB_MissionBonus GetRootAsFB_MissionBonus(ByteBuffer _bb) { return GetRootAsFB_MissionBonus(_bb, new FB_MissionBonus()); }
  public static FB_MissionBonus GetRootAsFB_MissionBonus(ByteBuffer _bb, FB_MissionBonus obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionBonus __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long BindMoney { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)189; } }
  public long Exp { get { int o = __offset(8); return o != 0 ? bb.GetLong(o + bb_pos) : (long)538; } }
  public int GetMenPaiItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiNumList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiNumListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int DoubleBonusCost { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SectionProcess { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemFlagIndex { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public long YuanShenExp { get { int o = __offset(24); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }

  public static Offset<FB_MissionBonus> CreateFB_MissionBonus(FlatBufferBuilder builder,
      int Id = 0,
      long BindMoney = 189,
      long Exp = 538,
      VectorOffset MenPaiItemIDList = default(VectorOffset),
      VectorOffset MenPaiNumList = default(VectorOffset),
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      int DoubleBonusCost = 0,
      int SectionProcess = -1,
      int ItemFlagIndex = -1,
      long YuanShenExp = -1) {
    builder.StartObject(11);
    FB_MissionBonus.AddYuanShenExp(builder, YuanShenExp);
    FB_MissionBonus.AddExp(builder, Exp);
    FB_MissionBonus.AddBindMoney(builder, BindMoney);
    FB_MissionBonus.AddItemFlagIndex(builder, ItemFlagIndex);
    FB_MissionBonus.AddSectionProcess(builder, SectionProcess);
    FB_MissionBonus.AddDoubleBonusCost(builder, DoubleBonusCost);
    FB_MissionBonus.AddItemNumList(builder, ItemNumList);
    FB_MissionBonus.AddItemIDList(builder, ItemIDList);
    FB_MissionBonus.AddMenPaiNumList(builder, MenPaiNumList);
    FB_MissionBonus.AddMenPaiItemIDList(builder, MenPaiItemIDList);
    FB_MissionBonus.AddId(builder, Id);
    return FB_MissionBonus.EndFB_MissionBonus(builder);
  }

  public static void StartFB_MissionBonus(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddBindMoney(FlatBufferBuilder builder, long BindMoney) { builder.AddLong(1, BindMoney, 189); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(2, Exp, 538); }
  public static void AddMenPaiItemIDList(FlatBufferBuilder builder, VectorOffset MenPaiItemIDListOffset) { builder.AddOffset(3, MenPaiItemIDListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiNumList(FlatBufferBuilder builder, VectorOffset MenPaiNumListOffset) { builder.AddOffset(4, MenPaiNumListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(5, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(6, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDoubleBonusCost(FlatBufferBuilder builder, int DoubleBonusCost) { builder.AddInt(7, DoubleBonusCost, 0); }
  public static void AddSectionProcess(FlatBufferBuilder builder, int SectionProcess) { builder.AddInt(8, SectionProcess, -1); }
  public static void AddItemFlagIndex(FlatBufferBuilder builder, int ItemFlagIndex) { builder.AddInt(9, ItemFlagIndex, -1); }
  public static void AddYuanShenExp(FlatBufferBuilder builder, long YuanShenExp) { builder.AddLong(10, YuanShenExp, -1); }
  public static Offset<FB_MissionBonus> EndFB_MissionBonus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionBonus>(o);
  }
};

public sealed class FB_MissionBonusContainer : Table {
  public static FB_MissionBonusContainer GetRootAsFB_MissionBonusContainer(ByteBuffer _bb) { return GetRootAsFB_MissionBonusContainer(_bb, new FB_MissionBonusContainer()); }
  public static FB_MissionBonusContainer GetRootAsFB_MissionBonusContainer(ByteBuffer _bb, FB_MissionBonusContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionBonusContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionBonusContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionBonus GetItems(int j) { return GetItems(new FB_MissionBonus(), j); }
  public FB_MissionBonus GetItems(FB_MissionBonus obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionBonusContainer> CreateFB_MissionBonusContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionBonusContainer.AddItems(builder, items);
    return FB_MissionBonusContainer.EndFB_MissionBonusContainer(builder);
  }

  public static void StartFB_MissionBonusContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionBonus>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionBonusContainer> EndFB_MissionBonusContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionBonusContainer>(o);
  }
  public static void FinishFB_MissionBonusContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionBonusContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
