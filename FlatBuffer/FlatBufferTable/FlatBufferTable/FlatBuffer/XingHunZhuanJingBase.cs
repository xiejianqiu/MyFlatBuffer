// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XingHunZhuanJingBase : Table {
  public static FB_XingHunZhuanJingBase GetRootAsFB_XingHunZhuanJingBase(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingBase(_bb, new FB_XingHunZhuanJingBase()); }
  public static FB_XingHunZhuanJingBase GetRootAsFB_XingHunZhuanJingBase(ByteBuffer _bb, FB_XingHunZhuanJingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XingHunZhuanJingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Position { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetUnLockIdList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockIdListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnLockValueList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnLockValueListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int PassiveSkillId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ImpactId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SkillId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetStrDescIdList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int StrDescIdListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public float GetDescParamList(int j) { int o = __offset(32); return o != 0 ? bb.GetFloat(__vector(o) + j * 4) : (float)0; }
  public int DescParamListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunZhuanJingBase> CreateFB_XingHunZhuanJingBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int SkillType = 0,
      int MenPai = -1,
      int Position = -1,
      int MaxLevel = -1,
      int UnLockType = -1,
      VectorOffset UnLockIdList = default(VectorOffset),
      VectorOffset UnLockValueList = default(VectorOffset),
      int PassiveSkillId = -1,
      int ImpactId = -1,
      int SkillId = -1,
      VectorOffset StrDescIdList = default(VectorOffset),
      VectorOffset DescParamList = default(VectorOffset)) {
    builder.StartObject(15);
    FB_XingHunZhuanJingBase.AddDescParamList(builder, DescParamList);
    FB_XingHunZhuanJingBase.AddStrDescIdList(builder, StrDescIdList);
    FB_XingHunZhuanJingBase.AddSkillId(builder, SkillId);
    FB_XingHunZhuanJingBase.AddImpactId(builder, ImpactId);
    FB_XingHunZhuanJingBase.AddPassiveSkillId(builder, PassiveSkillId);
    FB_XingHunZhuanJingBase.AddUnLockValueList(builder, UnLockValueList);
    FB_XingHunZhuanJingBase.AddUnLockIdList(builder, UnLockIdList);
    FB_XingHunZhuanJingBase.AddUnLockType(builder, UnLockType);
    FB_XingHunZhuanJingBase.AddMaxLevel(builder, MaxLevel);
    FB_XingHunZhuanJingBase.AddPosition(builder, Position);
    FB_XingHunZhuanJingBase.AddMenPai(builder, MenPai);
    FB_XingHunZhuanJingBase.AddSkillType(builder, SkillType);
    FB_XingHunZhuanJingBase.AddIcon(builder, Icon);
    FB_XingHunZhuanJingBase.AddName(builder, Name);
    FB_XingHunZhuanJingBase.AddID(builder, ID);
    return FB_XingHunZhuanJingBase.EndFB_XingHunZhuanJingBase(builder);
  }

  public static void StartFB_XingHunZhuanJingBase(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddSkillType(FlatBufferBuilder builder, int SkillType) { builder.AddInt(3, SkillType, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(4, MenPai, -1); }
  public static void AddPosition(FlatBufferBuilder builder, int Position) { builder.AddInt(5, Position, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(6, MaxLevel, -1); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(7, UnLockType, -1); }
  public static void AddUnLockIdList(FlatBufferBuilder builder, VectorOffset UnLockIdListOffset) { builder.AddOffset(8, UnLockIdListOffset.Value, 0); }
  public static VectorOffset CreateUnLockIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnLockValueList(FlatBufferBuilder builder, VectorOffset UnLockValueListOffset) { builder.AddOffset(9, UnLockValueListOffset.Value, 0); }
  public static VectorOffset CreateUnLockValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnLockValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassiveSkillId(FlatBufferBuilder builder, int PassiveSkillId) { builder.AddInt(10, PassiveSkillId, -1); }
  public static void AddImpactId(FlatBufferBuilder builder, int ImpactId) { builder.AddInt(11, ImpactId, -1); }
  public static void AddSkillId(FlatBufferBuilder builder, int SkillId) { builder.AddInt(12, SkillId, -1); }
  public static void AddStrDescIdList(FlatBufferBuilder builder, VectorOffset StrDescIdListOffset) { builder.AddOffset(13, StrDescIdListOffset.Value, 0); }
  public static VectorOffset CreateStrDescIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartStrDescIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescParamList(FlatBufferBuilder builder, VectorOffset DescParamListOffset) { builder.AddOffset(14, DescParamListOffset.Value, 0); }
  public static VectorOffset CreateDescParamListVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartDescParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunZhuanJingBase> EndFB_XingHunZhuanJingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingBase>(o);
  }
};

public sealed class FB_XingHunZhuanJingBaseContainer : Table {
  public static FB_XingHunZhuanJingBaseContainer GetRootAsFB_XingHunZhuanJingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_XingHunZhuanJingBaseContainer(_bb, new FB_XingHunZhuanJingBaseContainer()); }
  public static FB_XingHunZhuanJingBaseContainer GetRootAsFB_XingHunZhuanJingBaseContainer(ByteBuffer _bb, FB_XingHunZhuanJingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XingHunZhuanJingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XingHunZhuanJingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XingHunZhuanJingBase GetItems(int j) { return GetItems(new FB_XingHunZhuanJingBase(), j); }
  public FB_XingHunZhuanJingBase GetItems(FB_XingHunZhuanJingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XingHunZhuanJingBaseContainer> CreateFB_XingHunZhuanJingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XingHunZhuanJingBaseContainer.AddItems(builder, items);
    return FB_XingHunZhuanJingBaseContainer.EndFB_XingHunZhuanJingBaseContainer(builder);
  }

  public static void StartFB_XingHunZhuanJingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XingHunZhuanJingBaseContainer> EndFB_XingHunZhuanJingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XingHunZhuanJingBaseContainer>(o);
  }
  public static void FinishFB_XingHunZhuanJingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_XingHunZhuanJingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
